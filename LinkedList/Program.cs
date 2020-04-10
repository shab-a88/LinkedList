using System;

namespace LinkedList
{
    class Program
    {
        public class Node 
        {
            public Node()
            {
            }

            public Node(int i)
            {
                Value = i;
                Next = null;
            }

            public int Value { get; set; }
            public Node Next { get; set; }

            public void AddToEnd(int data)
            {
                if (Next == null)
                {
                    Next = new Node(data);
                }
                else
                {
                    Next.AddToEnd(data);
                }
            }

            public void AddToFirst(int data) 
            {

            }
        }
        static void Main(string[] args)
        {
            Node one = new Node() { Value = 9 };
            Node first = new Node() { Value = 1 };
            one.Next = first;
            Node middle = new Node() { Value = 3 };
            first.Next = middle;
            Node last = new Node() { Value = 5 };
            middle.Next = last;
            last.AddToEnd(8);
            PrintList(one);

        }

        private static void PrintList(Node node)
        {
            while(node != null) 
            {
                Console.Write(node.Value);
                node = node.Next;
            }
        }
    }
}
