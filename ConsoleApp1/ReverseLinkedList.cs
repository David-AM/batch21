internal static class ReverseLinkedList
{
        public class Node(int data)
    {
        public int Data = data;
        public Node? Next;
    }

    public static class List
    {
        private static Node? head;
        private static Node? tail;

        public static void Append(int val)
        {
            Node newNode = new Node(val);
            if (head == null)
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail!.Next = newNode;
                tail = newNode;
            }

            Console.WriteLine($"Appended {val}");
        }

        public static void Print()
        {
            Console.Write("Sequence: ");
            Node? current = head;

            while (current != null)
            {
                Console.Write(current.Data + "");
                if (current.Next != null)
                {
                    Console.Write("->");
                }
                current = current.Next;
            }
            Console.WriteLine();
        }
        public static void PrintReverse()
        {
            Node? prev = null;
            Node? current = head;
            Node? next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = prev;
                prev = current;
                current = next;
            }

            head = prev;
            Console.Write("Reversed: ");
            while (head != null)
            {
                Console.Write("" + head.Data);
                if (head.Next != null)
                    Console.Write("->");
                head = head.Next;
            }
            Console.WriteLine();
        }
    }

}

// Append(5); Append(10); Append(15); Print(); PrintReverse();