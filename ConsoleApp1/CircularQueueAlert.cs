internal class CircularQueueAlert
{
    private const int capacity = 3;
    private static Queue<int> buffer = new Queue<int>();

    public static void Log(int val)
    {

        if (buffer.Count == capacity)
        {
            Console.WriteLine("Critical: Buffer Full");
        }
        else if (buffer.Count >= Math.Ceiling(capacity * 2.0 / 3.0))
        {
            Console.WriteLine("Warning: Buffer at 66%");
        }
        
        if (buffer.Count == capacity)
        {
            Console.WriteLine($"Overwritten the oldest with {val}");
            buffer.Dequeue();
        }
        else
        {
            Console.WriteLine($"Logged {val}");
        }

        buffer.Enqueue(val);
    }

    public static void Read()
    {
        if (buffer.Count == 0) return;

        int val = buffer.Dequeue();

        Console.WriteLine($"Read {val}");
    }
}

// Log(1); Log(2); Log(3); Log(4); Read();