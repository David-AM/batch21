internal class CircularQueue
{
    private const int capacity = 3;
    static int[] buffer = new int[capacity];
    static int front = 0;
    static int back = 0;
    static int count = 0;

    public static void Log(int val)
    {

        if (count == capacity)
        {
            Console.WriteLine("Buffer Full");
            return;
        }

        buffer[back] = val;
        back = (back + 1) % capacity;
        count++;

        Console.WriteLine($"Logged {val}");
    }

    public static void Read()
    {
        if (count == 0)
            return;

        int val = buffer[front];
        front = (front + 1) % capacity;
        count--;

        Console.WriteLine($"Read {val}");
    }
}