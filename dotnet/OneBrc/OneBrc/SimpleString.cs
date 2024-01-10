using System.Text;

namespace OneBrc;

internal static class SimpleString
{
    public static void Run(string filePath)
    {
        var d = new Dictionary<string, Summary>();

        foreach (var str in File.ReadLines(filePath))
        {
            var data = str.Split(';');
            var name = data[0];
            var value = double.Parse(data[1]);

            if (!d.TryGetValue(name, out var summary))
                d[name] = summary = new Summary();
            summary.Apply(value);
        }

        var sb = new StringBuilder();

        foreach (var (name, summary) in d.OrderBy(p => p.Key))
            sb.AppendLine($"{name} {summary.Min:N1}/{summary.Average:N1}/{summary.Max:N1}");

        Console.WriteLine(sb.ToString());
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