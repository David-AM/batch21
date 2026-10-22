internal static class LinkedListInsert
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

        public static void Insert(int val)
        {
            Node newNode = new Node(val);

            if (head == null || val <= head.Data)
            {
                newNode.Next = head;
                head = newNode;

                if (tail == null)
                {
                    tail = newNode;
                }
            }
            else
            {
                Node current = head;

                while (current.Next != null && current.Next.Data < val)
                {
                    current = current.Next;
                }

                newNode.Next = current.Next;
                current.Next = newNode;

                if (newNode.Next == null)
                {
                    tail = newNode;
                }
            }

            Console.WriteLine($"Inserted {val}");
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
    }

}

// Insert(5); Insert(2); Insert(8); Print();
