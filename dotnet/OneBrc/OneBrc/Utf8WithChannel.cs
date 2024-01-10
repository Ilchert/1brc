using System.Buffers;
using System.Buffers.Binary;
using System.Buffers.Text;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Channels;

namespace OneBrc;

internal static class Utf8WithChannel
{
    public static async Task Run(string filePath)
    {
        var channel = Channel.CreateBounded<Segment>(20);

        var processors = new List<Task<Dictionary<Memory<byte>, Summary>>>();
        for (int i = 0; i < Environment.ProcessorCount; i++)
        {
            processors.Add(Task.Run(async () =>
            {
                var dict = new Dictionary<Memory<byte>, Summary>(new MemoryEqualityComparer());

                await foreach (var item in channel.Reader.ReadAllAsync())
                {
                    var segment = item.MemoryOwner.Memory[..item.Length];
                    while (true)
                    {
                        if (segment.IsEmpty)
                            break;

                        var commaIndex = segment.Span.IndexOf((byte)';');
                        var station = segment[..commaIndex];
                        segment = segment[(commaIndex + 1)..];

                        var endLineIndex = segment.Span.IndexOf((byte)'\r');

                        var temperature = segment[..endLineIndex];
                        segment = segment[(endLineIndex + 2)..];

                        if (!Utf8Parser.TryParse(temperature.Span, out double temperatureValue, out _))
                            throw new FormatException();


                        if (!dict.TryGetValue(station, out var summary))
                        {
                            summary = new Summary();
                            dict[station.ToArray()] = summary;
                        }
                        summary.Apply(temperatureValue);
                    }

                    item.MemoryOwner.Dispose();
                }
                return dict;
            }));
        }

        using var handle = File.OpenHandle(filePath, FileMode.Open, FileAccess.Read, options: FileOptions.SequentialScan);
        var size = RandomAccess.GetLength(handle);
        const int CacheSize = 10 * 1024 * 1024;

        var currentPosition = 0L;
        var memoryOwner = MemoryPool<byte>.Shared.Rent(CacheSize);
        var remainBytes = 0;
        while (true)
        {
            var cache = memoryOwner.Memory;
            var readBytes = RandomAccess.Read(handle, cache.Span[remainBytes..], currentPosition);
            if (readBytes == 0)
                break;

            currentPosition += readBytes;

            var segment = cache[..(readBytes + remainBytes)];
            var endOfSegment = segment.Span.LastIndexOf((byte)'\n');

            var s = new Segment(memoryOwner, endOfSegment + 1);

            memoryOwner = MemoryPool<byte>.Shared.Rent(CacheSize);
            var remainingSegment = segment[s.Length..];
            remainingSegment.CopyTo(memoryOwner.Memory);
            remainBytes = remainingSegment.Length;

            await channel.Writer.WriteAsync(s);
        }
        channel.Writer.Complete();

        var allDictionaries = await Task.WhenAll(processors);
        var result = allDictionaries
            .SelectMany(p => p)
            .ToLookup(p => p.Key, p => p.Value, new MemoryEqualityComparer());


        var sb = new StringBuilder();

        foreach (var grouping in result.OrderBy(p => p.Key, new MemoryComparer()))
        {
            var summary = grouping.Aggregate((s, p) => s.Apply(p));

            sb.AppendLine($"{Encoding.UTF8.GetString(grouping.Key.Span)} {summary.Min:N1}/{summary.Average:N1}/{summary.Max:N1}");
        }

        Console.WriteLine(sb.ToString());
    }

    record struct Segment(IMemoryOwner<byte> MemoryOwner, int Length);

    private class MemoryComparer : IComparer<Memory<byte>>
    {
        public int Compare(Memory<byte> x, Memory<byte> y)
        {
            return x.Span.SequenceCompareTo(y.Span);
        }
    }
    private class MemoryEqualityComparer : IEqualityComparer<Memory<byte>>
    {
        public bool Equals(Memory<byte> x, Memory<byte> y) =>
            x.Span.SequenceEqual(y.Span);

        public int GetHashCode([DisallowNull] Memory<byte> obj)
        {
            var span = obj.Span;

            return span.Length switch
            {
                > 15 => BinaryPrimitives.ReadUInt128LittleEndian(span).GetHashCode(),
                > 7 => BinaryPrimitives.ReadInt64LittleEndian(span).GetHashCode(),
                > 4 => BinaryPrimitives.ReadInt32LittleEndian(span),
                > 2 => BinaryPrimitives.ReadInt16LittleEndian(span),
                1 => span[0],
                0 => 0,
                _ => 0,
            };
        }
    }

    private class Summary
    {
        public double Min;
        public double Max;
        public double Sum;
        public long Count;
        public double Average => Sum / Count;

        public void Apply(double value)
        {
            if (value < Min)
                Min = value;
            else if (value > Max)
                Max = value;
            Sum += value;
            Count++;
        }

        public Summary Apply(Summary other)
        {
            if (other.Min < Min)
                Min = other.Min;
            if (other.Max > Max)
                Max = other.Max;
            Sum += other.Sum;
            Count += other.Count;
            return this;
        }
    }
}
