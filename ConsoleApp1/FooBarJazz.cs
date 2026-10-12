internal static class FooBarJazz
{
    internal static void Generate(int x)
    {
        for (int i = 1; i <= x; i++)
        {
            if (i % 3 == 0 && i % 5 == 0 && i % 7 == 0)
            {
                Console.Write("FooBarJazz");
            }
            else if (i % 3 == 0 && i % 5 == 0)
            {
                Console.Write("FooBar ");
            }
            else if (i % 3 == 0 && i % 7 == 0)
            {
                Console.Write("FooJazz ");
            }
            else if (i % 5 == 0 && i % 7 == 0)
            {
                Console.Write("BarJazz ");
            }
            else if (i % 3 == 0)
            {
                Console.Write("Foo, ");
            }
            else if (i % 5 == 0)
            {
                Console.Write("Bar, ");
            }
            else if (i % 7 == 0)
            {
                Console.Write("Jazz, ");
            }
            else
            {
                Console.Write($"{i}, ");
            }
        }
    }
}

// Generate(105);