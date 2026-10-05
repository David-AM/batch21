Queue<string> Q = new Queue<string>();

void Enqueue(string y)
{
    Q.Enqueue(y);
    Console.WriteLine($"Queued {y}");
}

void Process()
{
    if (Q.Count == 0)
    {
        Console.WriteLine("Queue is empty");
        return;
    }

    string val = Q.Dequeue();
    Console.WriteLine($"Processed {val}");
}

Enqueue("A"); Enqueue("B"); Process(); Process();