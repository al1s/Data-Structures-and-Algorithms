using System;
using LinkedList.Classes;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            Node node = new Node(10);
            Classes.LinkedList ll = new Classes.LinkedList(node);
            ll.Add(3);
            ll.Add(6);
            Console.WriteLine("Initial LL");
            ll.Print();
            ll.Append(65);
            Console.WriteLine("LL after appending 65");
            ll.Print();

            
            Node node1 = new Node(10);
            ll.AddBefore(node1, 66);
            Console.WriteLine("LL after adding 66 before 10");
            ll.Print();
            ll.AddAfter(node1, 99);
            Console.WriteLine("LL after adding 99 after 10");
            ll.Print();
            ll.ToArray();
            Console.ReadLine();
        }
    }
}
