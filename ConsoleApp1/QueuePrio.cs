internal static class QueuePrio
{
    static Queue<(string value, int Priority, int Order)> Q = new Queue<(string, int, int)>();
    private static int nextOrder = 0;
    internal static void Enqueue(string val, int p)
    {
        Q.Enqueue((val, p, nextOrder++));
        Console.WriteLine($"Queued {val} with priority {p}");
    }

    internal static void Process()
    {
        if (Q.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        var items = Q.ToList();

        int highestPriority = items.Max(x => x.Priority);
        var selected = items
           .First(x => x.Priority == highestPriority);
        
        var remaining = new Queue<(string Value, int Priority, int Order)>();

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

// Enqueue("A", 1); Enqueue("B", 5); Enqueue("C", 5); Process(); Process();