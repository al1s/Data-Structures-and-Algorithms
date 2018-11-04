using System;
using Tree.Classes;

namespace findMaxValueTree
{
    public class Program
    {
        /// <summary>
        /// Given a binary tree of integers returns the max int value
        /// </summary>
        /// <param name="tree">Binary tree to search through</param>
        /// <returns>Max integer value</returns>
        public static int FindMaxValue(BinaryTree<int> tree)
        {
            int maxValue = int.MinValue;     
            void TreeTraverser(Node<int> root)
            {
                if (root.Value > maxValue) maxValue = root.Value;
                if (root.LeftChild != null)
                    TreeTraverser(root.LeftChild);
                if (root.RightChild != null)
                    TreeTraverser(root.RightChild);
            }
            TreeTraverser(tree.Root);
            return maxValue;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
