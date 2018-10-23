using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{
    public class Stack
    {
        private Node _top { get; set; }
        private Node _node { get; set; }
        public Stack(Node Node)
        {
            _top = Node;
        }
        public void Push(Node node)
        {

        }
        public Node Pop()
        {
            return _top;
        }
        public Node Peek()
        {
            return _top;
        }
    }
}
