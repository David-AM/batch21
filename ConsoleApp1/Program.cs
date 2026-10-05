// // See https://aka.ms/new-console-template for more information
// // static int Factorial(int x)
// // {
// //     if (x == 0) return 1;
// //     return x * Factorial(x - 1);
// // }
// // Console.WriteLine("Hello, World!");
// // var studentName = "Alice";      // Inferred as string
// // var studentAge = 20;            // Inferred as int
// // var isEnrolled = true;          // Inferred as bool
// // var grades = new List<int>();   // Inferred as List<int>

// // Console.WriteLine(studentName);
// // string a2 = "\\\\server\\fileshare\\helloworld.cs";
// // string raw = """This string contains "double quotes" without escaping.""";
// // string s = $"""The date and time is {DateTime.Now}""";
// // Console.WriteLine(Factorial(2));

// static void Foo(ref int p)
// {
//     p = p + 1;          // Only the copy 'p' is incremented
//     // Console.WriteLine($"p = {p}"); // Output: 9
// }

// int x = 8;
// Foo(ref x);                 // A copy of x (value 8) is passed to p
// // Console.WriteLine($"x = {x}");   // Output: 8 (x remains unchanged)

// string a, b;
// Split("Stevie Ray Vaughan", out a, out b);
// // Console.WriteLine(a); // Output: Stevie Ray
// // Console.WriteLine(b); // Output: Vaughn

// void Split(string name, out string firstNames, out string lastName)
// {
//     int i = name.LastIndexOf(' ');
//     firstNames = name.Substring(0, i);
//     lastName = name.Substring(i + 1);
// }

// string str1 = "Hello";
// string str2 = "Hello";
// // bool sameReference = ReferenceEquals(str1, str2); // May be true due to string interning
// bool sameContent = str1 == str2;

// // Console.WriteLine(sameContent);

// var value = "";
// if (value is string str && str.Length > 0)
// {
//     Console.WriteLine($"Non-empty string: {str}");
// }

// int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// // Index from end operator (^)
// int lastElement = numbers[^1];
// // Console.WriteLine(lastElement);

// int[] number = { 2, 5, 7, 8, 10 };
// var result = number.Where(n => n > 5).Select(n => n * 2);
// foreach (var n in result)
// {
//     // Console.WriteLine(n);
// }

// static void Generate(int x)
// {
//     for (int i = 1; i <= x; i++)
//     {
//         if (i % 3 == 0 && i % 5 == 0)
//         {
//             Console.Write("FooBar ");
//         }
//         else if (i % 3 == 0)
//         {
//             Console.Write("Foo ");
//         }
//         else if (i % 5 == 0)
//         {
//             Console.Write("Bar ");
//         }
//         else
//         {
//             Console.Write($"{i} ");
//         }
//     }
// }

// // Generate(15);

// Queue<string> Q = new Queue<string>();

// void Enqueue(string y)
// {
//     Q.Enqueue(y);
//     Console.WriteLine($"Queued {y}");
// }

// void Process()
// {
//     if (Q.Count == 0)
//     {
//         Console.WriteLine("Queue is empty");
//         return;
//     }

//     string val = Q.Dequeue();
//     Console.WriteLine($"Processed {val}");
// }

// // Enqueue("A"); Enqueue("B"); Process(); Process();
// Stack<string> words = new Stack<string>();
// void Type(String y)
// {
//     words.Push(y);
//     Console.WriteLine($"Typed {words.Peek()}");
// }
// void Undo()
// {
//     string topWord = words.Pop();
//     Console.WriteLine($"Undid {topWord}");
// }

// // Type("foo"); Type("bar"); Undo(); Undo();
// public class Node
// {
//     public int Data;
//     public Node Next;

//     public Node(int data)
//     {
//         Data = data;
//         Next = null;
//     }
// }
// class Linkedlist
// {
//     private static Node head;
//     private static Node tail;
//     public static void Append(int val)
//     {
//         Node newNode = new Node(val);
//         if (head == null)
//         {
//             head = newNode;
//             tail = newNode;
//         }
//         else
//         {
//             tail.Next = newNode;
//             tail = newNode;
//         }
//         Console.WriteLine($"Appended {val}");
//     }
// }