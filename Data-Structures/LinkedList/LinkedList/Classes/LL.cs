using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LL
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
        /// <summary>
        /// Append new element to the end of the linked list
        /// </summary>
        /// <param name="value"></param>
        public void Append(object value)
        {
            Node newNode = new Node(value);
            Current = Head;
            while (Current.Next != null)
            {
                Current = Current.Next;
            }
            Current.Next = newNode;
            Current = Head;
        } 
        /// <summary>
        /// Add a new node before existing node
        /// </summary>
        /// <param name="existingNode">The node before which to add new node</param>
        /// <param name="value">Value of the added node</param>
        public void AddBefore(Node existingNode, object value)
        {
            if (Head.Value.Equals(existingNode.Value))
            {
                Add(value);
                return;
            }
            Current = Head;
            Node newNode = new Node(value);
            while(Current.Next != null)
            {
                if(Current.Next.Value.Equals(existingNode.Value))
                {
                    newNode.Next = Current.Next;
                    Current.Next = newNode;
                    return;
                }
                Current = Current.Next;
            }
        }
        /// <summary>
        /// Add a new node after the given existing node
        /// </summary>
        /// <param name="existingNode">The node after which to add new node</param>
        /// <param name="value">Value of the added node</param>
        public void AddAfter(Node existingNode, object value)
        {
            Current = Head;
            Node newNode = new Node(value);
            while(Current.Next != null && !Current.Value.Equals(existingNode.Value))
            {
                Current = Current.Next;
            }
            newNode.Next = Current.Next;
            Current.Next = newNode;
        }
        /// <summary>
        /// Convert the linked list into an Array (naive way)
        /// </summary>
        /// <returns>Array of nodes' values</returns>
        public object[] ToArray()
        {
            int length = 1;

            int i = 0;
            Current = Head;
            while(Current.Next != null)
            {
                length += 1;
                Current = Current.Next;
            }
            Current = Head;
            object[] result = new object[length];
            while(Current.Next != null)
            {
                result[i] = Current.Value;
                i += 1;
                Current = Current.Next;
            }
            result[i] = Current.Value;
            return result;
        }
    }
}
