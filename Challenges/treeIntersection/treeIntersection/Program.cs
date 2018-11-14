using System;
using System.Collections.Generic;
using Tree.Classes;

namespace treeIntersection
{
    public class Program
    {
        /// <summary>
        /// Depth-first preorder tree traverser with an arbitrary action to perform on each node
        /// </summary>
        /// <param name="node">A node to start traversing with</param>
        /// <param name="action">An action to perform on each node</param>
        private static void _traverser(Node<int> node, Action<Node<int>> action)
        {
            action(node);
            if (node.LeftChild != null)
                _traverser(node.LeftChild, action);

            if (node.RightChild != null)
                _traverser(node.RightChild, action);
        }
        /// <summary>
        /// A comparer for two binary trees
        /// </summary>
        /// <param name="tree1">First tree for comparision</param>
        /// <param name="tree2">Second tree for comparision</param>
        /// <returns>A list of intersection values</returns>
        public static List<int> TreeIntersection(BinaryTree<int> tree1, BinaryTree<int> tree2)
        {
            List<int> result = new List<int>();
            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            // Helper action to add node values to a list if they are in a hashtable
            void _checkElmInHashtable(Node<int> node)
            {
                if (dict.ContainsKey(node.Value))
                {
                    result.Add(node.Value);
                }
            }
            // Helper action to add node values to hashtable
            void _addToHashtable(Node<int> node) =>  
                dict.Add(node.Value, true);

            // add 
            _traverser(tree1.Root, _addToHashtable);
            // Chech all nodes in second tree for existing in prev saved dict
            _traverser(tree2.Root, _checkElmInHashtable);
            return result;
        }

        private static void Main(string[] args)
        {
            BinaryTree<int> binaryTree1 = new BinaryTree<int>();
            BinaryTree<int> binaryTree2 = new BinaryTree<int>();
            binaryTree1.Add(50);
            binaryTree1.Add(25);
            binaryTree1.Add(71);
            binaryTree1.Add(4);
            binaryTree1.Add(70);

            binaryTree2.Add(40);
            binaryTree2.Add(4);
            binaryTree2.Add(70);
            binaryTree2.Add(71);
            List<int> result = TreeIntersection(binaryTree1, binaryTree2);
            result.ForEach(elm => Console.Write($"{elm}, "));
            Console.ReadLine();
        }
    }
}
