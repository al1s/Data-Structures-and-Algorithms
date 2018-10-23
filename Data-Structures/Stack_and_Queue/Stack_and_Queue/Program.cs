using System;
using Stack_and_Queue.Classes;

namespace Stack_and_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Node nodeFirst = new Node("first");
            Node nodeSecond = new Node("second");
            Node nodeThird = new Node("third");
            Stack stack = new Stack(nodeFirst );
            stack.Push(nodeSecond);
            stack.Push(nodeThird);
            Console.WriteLine(stack.ToString());

            Queue queue = new Queue(nodeFirst );
            queue.Enqueue(nodeSecond);
            queue.Enqueue(nodeThird);
            Console.WriteLine(queue.ToString());
            Console.ReadLine();
        }
    }
}
