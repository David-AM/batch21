internal class CircularQueue
{
    private const int capacity = 3;
    // static int[] buffer = new int[capacity];
    private static Queue<int> buffer = new Queue<int>();
    // static int front = 0;
    // static int back = 0;
    // static int count = 0;

    public static void Log(int val)
    {

        if (buffer.Count == capacity)
        {
            Console.WriteLine("Buffer Full");
            return;
        }

        // buffer[back] = val;
        // back = (back + 1) % capacity;
        // count++;
        buffer.Enqueue(val);

        Console.WriteLine($"Logged {val}");
    }

    public static void Read()
    {
        if (buffer.Count == 0)
            return;

        // int val = buffer[front];
        // front = (front + 1) % capacity;
        // count--;
        int val = buffer.Dequeue();

        Console.WriteLine($"Read {val}");
    }
}