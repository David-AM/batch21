using System;
using System.Text;
internal static class FooBarJazzHuzz
{
    private static readonly SortedDictionary<int, string> Rules = new()
    {
        { 3, "foo" },
        { 4, "baz" },
        { 5, "bar" },
        { 7, "jazz" },
        { 9, "huzz" }
    };
    internal static void Generate(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            StringBuilder result = new StringBuilder();

            foreach (var rule in Rules)
            {
                if (i % rule.Key == 0)
                    result.Append(rule.Value);
            }
            if (result.Length == 0)
                result.Append(i);

            Console.Write(result.ToString() + ", ");
        }
    }
}

// Generate(67);