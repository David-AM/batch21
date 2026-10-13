internal static class StackLimit
{
    static Stack<string> words = new Stack<string>();
    private const int capacity = 3;
    internal static void Type(string y)
    {
        if (words.Count >= capacity)
        {
            Console.WriteLine($"Dropped Bottom, Typed {y}");
            words.Pop();
        }
        else
        {
            Console.WriteLine($"Typed {y}");
        }
        words.Push(y);
    }
    internal static void Undo()
    {
        string botWords = words.Pop();
        Console.WriteLine($"Undid {botWords}");
    }
}

// Type("A"), Type("B"), Type("C"), Type("D"), Undo()