using System;
using Stack_and_Queue.Classes;
using queueWithStacks.Classes;

namespace queueWithStacks
{
    class Program
    {
        public void QueueWithStacks()
        {

        }
        static void Main(string[] args)
        {
            Node nodeFirst = new Node("first");
            Node nodeSecond = new Node("second");
            Node nodeThird = new Node("third");
            QueueWithStacks queue = new QueueWithStacks(nodeFirst);
            queue.Enqueue(nodeSecond);
            queue.Enqueue(nodeThird);
            Console.WriteLine("Initial queue:");
            Console.WriteLine(queue.ToString());
            Console.WriteLine();
            Console.WriteLine($"First element: {queue.Dequeue().Value}");
            Console.WriteLine("The queue after dequeue:");
            Console.WriteLine(queue.ToString());
            Console.WriteLine();
            Console.WriteLine($"Second element: {queue.Dequeue().Value}");
            Console.WriteLine("The queue after dequeue:");
            Console.WriteLine(queue.ToString());
            Console.WriteLine();
            Console.WriteLine($"Second element: {queue.Dequeue().Value}");
            Console.WriteLine("The queue after dequeue:");
            Console.WriteLine(queue.ToString());
            Console.ReadLine();
        }
    }
}
