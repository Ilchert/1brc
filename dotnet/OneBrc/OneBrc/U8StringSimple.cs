using System.Globalization;
using U8;

namespace OneBrc;

internal static class U8StringSimple
{
    public static void Run(string filePath)
    {
        var d = new Dictionary<U8String, Summary>();

        //await foreach (var str in U8File.ReadLinesAsync(filePath))
        foreach (var str in U8File.ReadLines(filePath))
        {
            var (name, valueStr) = str.SplitFirst(';');
            var value = double.Parse(valueStr, CultureInfo.InvariantCulture);

            if (!d.TryGetValue(name, out var summary))
                d[name] = summary = new Summary();
            summary.Apply(value);
        }

        foreach (var (name, summary) in d.OrderBy(p => p.Key))
            Console.WriteLine($"{name} {summary.Min:N1}/{summary.Average:N1}/{summary.Max:N1}");

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
    }
}
