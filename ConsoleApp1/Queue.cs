internal static class Queue
{
    static Queue<string> Q = new Queue<string>();

    internal static void Enqueue(string y)
    {
        Q.Enqueue(y);
        Console.WriteLine($"Queued {y}");
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

// Enqueue("A"); Enqueue("B"); Process(); Process();