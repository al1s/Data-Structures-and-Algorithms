using System;
using LinkedList.Classes;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(10);
            LL ll = new LL(node);
            ll.Add(3);
            ll.Add(6);
            ll.Print();
            Console.ReadLine();
        }
    }
}
