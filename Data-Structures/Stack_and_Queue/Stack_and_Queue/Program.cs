using System;
using Stack_and_Queue.Classes;

namespace Stack_and_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Node nodeFirst = new Node("first");
            Stack stack = new Stack(nodeFirst );
            Queue queue = new Queue(nodeFirst );
        }
    }
}
