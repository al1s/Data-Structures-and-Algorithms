using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList.Classes
{
    public class LList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public Node Current { get; set; }
        public LList()
        {

        }
        public LList(Node newNode)
        {
            Head = newNode;
            Tail = newNode;
            Current = newNode;
        }
        /// <summary>
        /// Add new element with a value to the linked list
        /// </summary>
        /// <param name="value">Value to be added</param>
        public void Add(object value)
        {
            if(Head == null)
            {
                Head = new Node(value);
                Tail = Head;
                Tail.Next = Head;
                Current = Head;
            }
            else
            {
                Node newNode = new Node(value);
                newNode.Next = Head;
                Head = newNode;
                Tail.Next = Head;
                Current = newNode;
            }
        }
        /// <summary>
        /// Print to console the content of the linked list
        /// </summary>
        public void Print()
        {
            Current = Head;
            while (Current != Tail)
            {
                Console.Write($"{Current.Value} --> ");
                Current = Current.Next;
            } 
            Console.WriteLine($"{Current.Value} --> HEAD");
            Current = Head;
        }
        /// <summary>
        /// Append new element to the end of the linked list
        /// </summary>
        /// <param name="value"></param>
        public void Append(object value)
        {
            if(Head == null)
            {
                Head = new Node(value);
                Tail = Head;
                Tail.Next = Head;
            }
            else
            {
                Node newNode = new Node(value);
                Tail.Next = newNode;
                Tail = newNode;
                Tail.Next = Head;
            }
            Current = Head;
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
            while(Current != Tail)
            {
                length += 1;
                Current = Current.Next;
            }
            Current = Head;
            object[] result = new object[length];
            while(Current != Tail)
            {
                result[i] = Current.Value;
                i += 1;
                Current = Current.Next;
            }
            result[i] = Current.Value;
            Current = Head;
            return result;
        }
    }
}
