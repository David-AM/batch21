internal class QueuePrioKeyword
{
    private Queue<(string value, int Priority, int Order)> Q
        = new Queue<(string, int, int)>();

    private Dictionary<string, int> rules
        = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

    private int nextOrder = 0;

    public void AddRule(string keyword, int priority)
    {
        rules[keyword] = priority;
    }

    public void Enqueue(string val)
    {
        int priority = 0;

        foreach (var rule in rules)
        {
            if (val.Contains(rule.Key, StringComparison.OrdinalIgnoreCase))
            {
                priority = rule.Value;
                break;
            }
        }

        Q.Enqueue((val, priority, nextOrder++));
        Console.WriteLine($"Queued {val} with priority {priority}");
    }

    public void Process()
    {
        if (Q.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        var items = Q.ToList();

        int highestPriority = items.Max(x => x.Priority);

        var selected = items.First(x => x.Priority == highestPriority);

        var remaining = new Queue<(string value, int Priority, int Order)>();
        bool removed = false;

        while (Q.Count > 0)
        {
            var item = Q.Dequeue();

            if (!removed && item.Order == selected.Order)
            {
                removed = true;
                continue;
            }

            remaining.Enqueue(item);
        }

        Q = remaining;

        Console.WriteLine($"Processed {selected.value}");
    }
}
