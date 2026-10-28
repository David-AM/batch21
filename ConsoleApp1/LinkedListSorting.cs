internal class LinkedListSorting
{
    private sealed class Node(int data)
    {
        public int Data { get; } = data;
        public Node? Next { get; set; }
    }

    private Node? _head;
    private Node? _tail;
    private Func<int, int, int>? _comparer;
    private readonly List<Func<int, bool>> _filters = new();

    public void SetSorting(Func<int, int, int> comparer)
    {
        ArgumentNullException.ThrowIfNull(comparer);
        _comparer = comparer;
    }

    public void AddFilter(Func<int, bool> filterRule)
    {
        ArgumentNullException.ThrowIfNull(filterRule);
        _filters.Add(filterRule);
    }

    public void Append(int val)
    {
        var newNode = new Node(val);

        if (_head is null)
        {
            _head = _tail = newNode;
        }
        else
        {
            _tail!.Next = newNode;
            _tail = newNode;
        }

        Console.WriteLine($"Appended {val}");
    }

    public void Print()
    {
        var values = new List<int>();
        for (Node? current = _head; current is not null; current = current.Next)
        {
            if (_filters.All(filter => filter(current.Data)))
            {
                values.Add(current.Data);
            }
        }

        IEnumerable<int> result = _comparer is null
            ? values
            : values.OrderBy(v => v, Comparer<int>.Create((a, b) => _comparer(a, b)));

        Console.WriteLine($"Sequence: {string.Join("->", result)}");
    }
}