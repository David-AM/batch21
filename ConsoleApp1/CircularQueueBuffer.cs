internal class CircularQueueBuffer
{
    private Queue<int> _buffer = new();
    private int _capacity;
    private bool _overwriteEnabled = true;

    public void CircularBuffer(int capacity = 3, bool overwriteEnabled = true)
    {
        SetCapacity(capacity);
        SetOverwritePolicy(overwriteEnabled);
    }

    public void SetCapacity(int n)
    {
        if (n <= 0)
        {
            Console.WriteLine("Capacity must be positive.");
        }

        _capacity = n;
        _buffer = new Queue<int>();
    }

    public void SetOverwritePolicy(bool isOverwriteEnabled)
    {
        _overwriteEnabled = isOverwriteEnabled;
    }

    public bool Log(int val)
    {
        if (_buffer.Count == _capacity)
        {
            if (!_overwriteEnabled)
            {
                Console.WriteLine($"Buffer full — rejected {val}");
                return false;
            }

            Console.WriteLine($"Overwritten the oldest with {val}");
            _buffer.Dequeue();
        }
        else
        {
            Console.WriteLine($"Logged {val}");
        }

        _buffer.Enqueue(val);
        return true;
    }

    public int? Read()
    {
        if (_buffer.Count == 0)
        {
            return null;
        }

        var val = _buffer.Dequeue();
        Console.WriteLine($"Read {val}");
        return val;
    }
}