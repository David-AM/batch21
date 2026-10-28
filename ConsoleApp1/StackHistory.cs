internal class StackHistory
{
    private readonly Stack<string> _words = new Stack<string>();
    private readonly Stack<string> _redoWords = new Stack<string>();
    private readonly int _capacity = 3;
    private readonly List<Func<string, bool>> _rules = new();

    public StackHistory(int capacity = 3)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(capacity, 1);
        _capacity = capacity;
    }

    public void AddValidationRule(Func<string, bool> rule)
    {
        ArgumentNullException.ThrowIfNull(rule);
        _rules.Add(rule);
    }

    public void Type(string word)
    {
        if (!IsValid(word))
        {
            Console.WriteLine($"Rejected {word}");
            return;
        }

        _redoWords.Clear();

        if (_words.Count >= _capacity)
        {
            DropBottom();
            Console.WriteLine($"Dropped Bottom, Typed {word}");
        }
        else
        {
            Console.WriteLine($"Typed {word}");
        }

        _words.Push(word);
    }

    public void Undo()
    {
        if (_words.Count == 0)
        {
            Console.WriteLine("Nothing to undo");
            return;
        }

        string word = _words.Pop();
        _redoWords.Push(word);
        Console.WriteLine($"Undid {word}");
    }

    public void Redo()
    {
        if (_redoWords.Count == 0)
        {
            Console.WriteLine("Nothing to redo");
            return;
        }

        string word = _redoWords.Pop();

        if (_words.Count >= _capacity)
        {
            DropBottom();
        }

        _words.Push(word);
        Console.WriteLine($"Redid {word}");
    }

    private bool IsValid(string word) => word is not null && _rules.All(rule => rule(word));

    private void DropBottom()
    {
        string[] items = _words.ToArray();
        _words.Clear();
        for (int i = items.Length - 2; i >= 0; i--)
        {
            _words.Push(items[i]);
        }
    }
}

// Type("A"); Type("B"); Undo(); Redo();