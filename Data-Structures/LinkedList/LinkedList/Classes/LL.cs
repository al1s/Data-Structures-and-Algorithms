using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    class LL
    {
        public Node Head { get; set; }
        public Node Current { get; set; }
        public LL(Node newNode)
        {
            Head = newNode;
            Current = newNode;
        }
        /// <summary>
        /// Add new element with a value to the linked list
        /// </summary>
        /// <param name="value">Value to be added</param>
        public void Add(object value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
            Current = newNode;
        }
        /// <summary>
        /// Print to console the content of the linked list
        /// </summary>
        public void Print()
        {
            Current = Head;
            while (Current.Next != null)
            {
                Console.WriteLine($"{Current.Value} -->");
                Current = Current.Next;
            } 
            Console.WriteLine($"{Current.Value} --> null");
            Current = Head;

        }
    }
}
