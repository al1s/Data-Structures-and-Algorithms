using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class Node<T>
    {
        /// <summary>
        /// Value of the node
        /// </summary>
        public T Value { get; set; }
        /// <summary>
        /// Left child of the node
        /// </summary>
        public Node<T> LeftChild { get; set; }
        /// <summary>
        /// Right child of the node
        /// </summary>
        public Node<T> RightChild { get; set; }
        public Node() { }
        public Node(T value)
        {
            Value = value;
            LeftChild = null;
            RightChild = null;
        }
    }
}
