using System;
using System.Text;
internal static class FooBarGenerator
{
    public sealed class RuleBasedSequenceGenerator
    {
        private readonly SortedDictionary<int, string> _rules = new();
        public RuleBasedSequenceGenerator AddRule(int divisor, string output)
        {
            if (divisor <= 0)
                throw new ArgumentOutOfRangeException(nameof(divisor), "Divisor must be greater than zero.");
            if (string.IsNullOrEmpty(output))
                throw new ArgumentException("Output must not be null or empty.", nameof(output));

            _rules[divisor] = output;
            return this;
        }

        public string Evaluate(int number)
        {
            var sb = new StringBuilder();

            foreach (var rule in _rules)
            {
                if (number % rule.Key == 0)
                    sb.Append(rule.Value);
            }

            return sb.Length == 0 ? number.ToString() : sb.ToString();
        }
        public string GenerateSequence(int start, int end)
        {
            if (start > end)
                throw new ArgumentException("Start must be less than or equal to end.", nameof(start));

            return string.Join(", ", Range(start, end).Select(Evaluate));
        }
        private static IEnumerable<int> Range(int start, int end)
        {
            for (long i = start; i <= end; i++)
                yield return (int)i;
        }
    }
}
// var generator = new RuleBasedSequenceGenerator()
//         .AddRule(3, "foo")
//         .AddRule(4, "baz")
//         .AddRule(5, "bar")
//         .AddRule(7, "jazz")
//         .AddRule(9, "huzz");
// Console.WriteLine(generator.GenerateSequence(1, 67));
