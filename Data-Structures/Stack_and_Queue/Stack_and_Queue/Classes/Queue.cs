using System;
using System.Collections.Generic;
using System.Text;
using Stack_and_Queue.Classes;

namespace Stack_and_Queue.Classes
{
    public class Queue
    {
        private Node _head { get; set; }
        private Node _tail { get; set; }
        public Queue(Node Node)
        {
            _head = Node;
            _tail = Node;
        }

        public void Enqueue(Node node)
        {

        }

        public Node Dequeue(Node node)
        {
            return _head;
        }

        public Node Peek(Node node)
        {
            return _head;
        }
    }
}
