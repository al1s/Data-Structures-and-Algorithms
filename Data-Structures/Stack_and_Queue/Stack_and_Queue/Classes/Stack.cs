using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_and_Queue.Classes
{
    public class Stack
    {
        /// <summary>
        /// Top of the stack
        /// </summary>
        private Node _top { get; set; }
        /// <summary>
        /// Stack constructor
        /// </summary>
        /// <param name="Node">First node in the stack</param>
        public Stack(Node Node)
        {
            _top = Node;
        }
        /// <summary>
        /// Push a node to the stack
        /// </summary>
        /// <param name="node">Node to be pushed</param>
        public void Push(Node node)
        {
            node.Next = _top;
            _top = node;
        }
        /// <summary>
        /// Pop a node from the stack (and delete it from the stack)
        /// </summary>
        /// <returns>Top node on the stack</returns>
        public Node Pop()
        {
            Node _temp = _top;
            _top = _top.Next;
            _temp.Next = null;
            return _temp;
        }
        /// <summary>
        /// Show a node from the stack (and keep it in the stack)
        /// </summary>
        /// <returns></returns>
        public Node Peek()
        {
            return _top;
        }
        /// <summary>
        /// Prepare the stack structure to be printed to console
        /// </summary>
        /// <returns>A string with all nodes int the stack</returns>
        public override string ToString()
        {
            string result = string.Empty;
            Node originTop = _top;
            while(_top != null)
            {
                if(_top == originTop) result = $"{_top.Value}(TOP)";
                else result = $"{result} -> {_top.Value}";
                _top = _top.Next;
            }
            _top = originTop;
            return $"{result} -> null";
        }
    }
}
