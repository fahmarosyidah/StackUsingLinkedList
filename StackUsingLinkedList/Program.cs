using System;

namespace StackUsingLinkedList
{
    class Node
    {
        public int info;
        public Node next;

        public Node(int i, Node n)
        {
            info = i;
            next = n;
        }
    }

    class Stacks
    {
        Node top;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
