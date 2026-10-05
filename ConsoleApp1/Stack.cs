internal static class Stack
{
    static Stack<string> words = new Stack<string>();
    internal static void Type(string y)
    {
        words.Push(y);
        Console.WriteLine($"Typed {words.Peek()}");
    }
    internal static void Undo()
    {
        string topWord = words.Pop();
        Console.WriteLine($"Undid {topWord}");
    }
}

// Type("foo"); Type("bar"); Undo(); Undo();