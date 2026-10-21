internal static class StackRedo
{
    static Stack<string> words = new Stack<string>();
    static Stack<string> RedoWords = new Stack<string>();
    private const int capacity = 3;
    internal static void Type(string y)
    {
        RedoWords.Clear();

        if (words.Count >= capacity)
        {
            Console.WriteLine($"Dropped Bottom, Typed {y}");
            string[] items = words.ToArray();
            words.Clear();
            for (int i = items.Length - 2; i >= 0; i--)
            {
                words.Push(items[i]);
            }
        }
        else
        {
            Console.WriteLine($"Typed {y}");
        }
        words.Push(y);
    }
    internal static void Undo()
    {
        if (words.Count == 0)
        {
            Console.WriteLine("Nothing to undo");
            return;
        }

        string botWords = words.Pop();
        RedoWords.Push(botWords);
        Console.WriteLine($"Undid {botWords}");
    }

    internal static void Redo()
    {
        if(RedoWords.Count() == 0)
        {
            Console.WriteLine("Nothing to redo");
            return;
        }

        string word = RedoWords.Pop();
        
        if(words.Count >= capacity)
        {
            string[] items = words.ToArray();
            words.Clear();
            for (int i = items.Length - 2; i >= 0; i--)
            {
                words.Push(items[i]);
            }
        }

        words.Push(word);
        Console.WriteLine($"Redid {word}"); 
    }
}

// Type("A"); Type("B"); Undo(); Redo();