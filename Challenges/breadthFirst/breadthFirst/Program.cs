using System;
using System.Collections.Generic;
using Tree.Classes;

namespace breadthFirst
{
    public class Program
    {
        /// <summary>
        /// Given a tree return a list of nodes in breadth-first traversal order 
        /// </summary>
        /// <param name="tree">A tree to traverse</param>
        /// <returns>A list of nodes</returns>
        public static List<int> BreadthFirst(BinaryTree<int> tree)
        {
            List<int> result = new List<int>();
            Queue<Node<int>> queue = new Queue<Node<int>>();
            queue.Enqueue(tree.Root);
            while(queue.Count > 0)
            {
                Node<int> node = queue.Dequeue();
                if(node.LeftChild != null)
                    queue.Enqueue(node.LeftChild);
                if(node.RightChild != null)
                    queue.Enqueue(node.RightChild);
                result.Add(node.Value);
            }
            return result;
        }
        public static void Main(string[] args)
        {
            BinaryTree<int> bt = new BinaryTree<int>();
            bt.Add(2);
            bt.Add(9);
            bt.Add(5);
            bt.Add(7);
            bt.Add(32);
            bt.Add(29);
            BreadthFirst(bt).ForEach(elm => Console.Write($"{elm}, "));
            Console.ReadLine();
        }
    }
}
