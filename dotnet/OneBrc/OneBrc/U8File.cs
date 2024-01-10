using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Linq;
using System.Runtime.CompilerServices;
using U8.InteropServices;
using U8;

namespace OneBrc
{
    internal class U8File
    {
        public static IEnumerable<U8String> ReadLines(string fileName)
        {
            using var fs = File.OpenRead(fileName);
            var readBuffer = new byte[4096].AsMemory();

            var endWithReturn = false;
            var consumed = 0;
            var remaining = 0;
            while ((consumed = fs.Read(readBuffer[remaining..].Span)) > 0)
            {
                var buffer = readBuffer[..(remaining + consumed)];
                while (TryReadLine(ref buffer, out var line, ref endWithReturn))
                {
                    var data = line.ToArray();
                    if (!U8String.IsValid(data))
                        throw new InvalidOperationException();

                    yield return U8Marshal.CreateUnsafe(data);
                }

                buffer.CopyTo(readBuffer);
                remaining = buffer.Length;
            }
        }

        public static async IAsyncEnumerable<U8String> ReadLinesAsync(string fileName, [EnumeratorCancellation] CancellationToken ct = default)
        {
            using var fs = File.OpenRead(fileName);
            var pipeReader = PipeReader.Create(fs);
            var endWithReturn = false;
            while (true)
            {
                var readResult = await pipeReader.ReadAsync(ct);
                ReadOnlySequence<byte> buffer = readResult.Buffer;
                while (TryReadLine(ref buffer, out ReadOnlySequence<byte> line, ref endWithReturn))
                {
                    ct.ThrowIfCancellationRequested();
                    var data = line.ToArray();
                    if (!U8String.IsValid(data))
                        throw new InvalidOperationException();

                    yield return U8Marshal.CreateUnsafe(data);
                }

                pipeReader.AdvanceTo(buffer.Start, buffer.End);

                if (readResult.IsCompleted)
                    break;
            }
            await pipeReader.CompleteAsync();
        }

        private static bool TryReadLine(ref Memory<byte> buffer, out Memory<byte> line, ref bool endWithReturn)
        {
            if (buffer.IsEmpty)
            {
                line = default;
                return false;
            }
            var bufferSpan = buffer.Span;

            if (endWithReturn && bufferSpan[0] == (byte)'\n')
            {
                buffer = buffer[1..];
                bufferSpan = buffer.Span;
            }

            var indexOfEnd = bufferSpan.IndexOfAny("\r\n"u8);
            var offset = 0;
            if (indexOfEnd >= 0)
            {
                offset += indexOfEnd;
                if (bufferSpan[indexOfEnd] == (byte)'\r')
                {
                    if (bufferSpan.Length > indexOfEnd + 1 &&
                        bufferSpan[indexOfEnd + 1] == (byte)'\n')
                        offset++;
                    else
                        endWithReturn = true;

                }
                offset++;
                line = buffer[..indexOfEnd];
                buffer = buffer[offset..];
                return true;
            }

            line = default;
            return false;
        }

        private static bool TryReadLine(ref ReadOnlySequence<byte> buffer, out ReadOnlySequence<byte> line, ref bool endWithReturn)
        {
            // Look for a EOL in the buffer.            
            var reader = new SequenceReader<byte>(buffer);
            if (endWithReturn)
                reader.IsNext((byte)'\n', true);

            if (reader.TryReadToAny(out line, "\r\n"u8, false))
            {
                if (reader.IsNext((byte)'\r', true))
                    endWithReturn = !reader.IsNext((byte)'\n', true);
                else
                    reader.Advance(1);

                buffer = buffer.Slice(reader.Position);
                return true;
            }

            return false;
        }
    }
}
