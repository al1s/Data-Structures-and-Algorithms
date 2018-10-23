using System;
using System.Collections.Generic;
using System.Text;
using Stack_and_Queue.Classes;

namespace Stack_and_Queue.Classes
{
    public class Queue
    {
        /// <summary>
        /// Head of the queue
        /// </summary>
        private Node _head { get; set; }
        /// <summary>
        /// Tail of the queue
        /// </summary>
        private Node _tail { get; set; }
        /// <summary>
        /// Queue constructor
        /// </summary>
        /// <param name="Node">First node in the queue</param>
        public Queue(Node Node)
        {
            _head = Node;
            _tail = Node;
        }

        /// <summary>
        /// Add a node to the queue
        /// </summary>
        /// <param name="node">Node to be added</param>
        public void Enqueue(Node node)
        {
            _tail.Next = node;
            _tail = node;

        }

        /// <summary>
        /// Remove and return a node (head) from the queue
        /// </summary>
        /// <returns>Node (head) to be returned and removed</returns>
        public Node Dequeue()
        {
            Node _temp = _head;
            _head = _head.Next;
            _temp.Next = null;
            return _temp;
        }

        public Node GetTail()
        {
            return _tail;
        }

        /// <summary>
        /// Return a node (head) from the queue
        /// </summary>
        /// <returns>Node (head) to be returned</returns>
        public Node Peek()
        {
            Node _temp = _head;
            _temp.Next = null;
            return _temp;
        }
        /// <summary>
        /// Prepare the queue structure to be printed to console
        /// </summary>
        /// <returns>A string with all nodes in the queue</returns>
        public override string ToString()
        {
            string result = string.Empty;
            Node originHead = _head;
            while(_head != _tail)
            {
                if(_head == originHead ) result = $"{_head.Value}(TOP)";
                else result = $"{result} -> {_head.Value}";
                _head = _head.Next;
            }
            _head = originHead;
            return $"{result} -> null";
        }
    }
}
