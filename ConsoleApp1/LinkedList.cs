internal static class LinkedList
{
    public class LinkedListNode
    {
        public int Data;
        public LinkedListNode Next;

        public LinkedListNode(int data)
        {
            Data = data;
            Next = null;
        }
    }

    public static class List
    {
        private static LinkedListNode head;
        private static LinkedListNode tail;

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
                tail.Next = newNode;
                tail = newNode;
            }

            Console.WriteLine($"Appended {val}");
        }

        public static void Print()
        {
            Console.Write("Sequence: ");
            LinkedListNode current = head;

            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
            }

        }
    }

}

// Append(5), Append(10), Print()