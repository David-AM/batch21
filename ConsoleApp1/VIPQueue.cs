internal static class VIPQueue
{
    static Queue<string> Q = new Queue<string>();

    internal static void Enqueue(string y)
    {
        Q.Enqueue(y);
        Console.WriteLine($"Queued {y}");
    }


    internal static void EnqueueVip(string y)
    {
        string[] items = Q.ToArray();
        Q.Clear();
        Q.Enqueue(y);

        foreach (string item in items)
        {
            Q.Enqueue(item);
        }

        Console.WriteLine($"VIP Queued {y}");
    }

    internal static void Process()
    {
        if (Q.Count == 0)
        {
            Console.WriteLine("Queue is empty");
            return;
        }

        string val = Q.Dequeue();
        Console.WriteLine($"Processed {val}");
    }
}

// Enqueue("A"); Enqueue("B"); EnqueueVip("C"); Process(); Process(); Process();