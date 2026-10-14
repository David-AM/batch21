internal static class LinkedList
{
    public class LinkedListNode(int data)
    {
        public int Data = data;
        public LinkedListNode? Next;
    }

    public static class List
    {
        private static LinkedListNode? head;
        private static LinkedListNode? tail;

        public static void Append(int val)
        {
            LinkedListNode newNode = new LinkedListNode(val);
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
            LinkedListNode? current = head;

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
    }

}

// Append(5), Append(10), Print()