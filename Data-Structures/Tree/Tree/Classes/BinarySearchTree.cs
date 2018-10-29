using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinarySearchTree 
    {
        /// <summary>
        /// Inner storage for a binary tree
        /// </summary>
        private BinaryTree<int> _bt { get; set; }
        /// <summary>
        /// Empty BST constructor
        /// </summary>
        public BinarySearchTree()
        {
            _bt = new BinaryTree<int>();
        }
        /// <summary>
        /// Add a new value to the BST starting from the existing root
        /// </summary>
        /// <param name="value">Value to be added</param>
        public void Add(int value)
        {
            if (_bt.Root == null) _bt.Add(value);
            else Add(value, _bt.Root);
        }
        /// <summary>
        /// Add a new value to the BST starting from a given node
        /// </summary>
        /// <param name="value">Value to be added</param>
        /// <param name="root">A node starting from which a node to be added</param>
        private void Add(int value, Node<int> root)
        {
            if (value > root.Value)
                if (root.RightChild != null)
                {
                    Add(value, root.RightChild);
                }
                else
                {
                    root.RightChild = new Node<int>(value);
                    return;
                }
            else if (value < root.Value)
            {
                if (root.LeftChild != null)
                {
                    Add(value, root.LeftChild);
                }
                else
                {
                    root.LeftChild = new Node<int>(value);
                    return;
                }
            }
            else throw new Exception($"Can't insert the value: {value}");
        }
        /// <summary>
        /// Search for a value in the BST
        /// </summary>
        /// <param name="value">Value to search for</param>
        /// <returns>Node where the value is stored, empty node if not found</returns>
        public Node<int> Search(int value)
        {
            if (value == _bt.Root.Value) return _bt.Root;
            else return Search(value, _bt.Root);
        }
        /// <summary>
        /// Search for a value in the BST starting from a given node
        /// </summary>
        /// <param name="value">Value to search for</param>
        /// <param name="root">A node to start from</param>
        /// <returns>Node where the value is stored, empty node if not found</returns>
        private Node<int> Search(int value, Node<int> root)
        {
            if (value == root.Value) return root;
            else if (value > root.Value && root.RightChild != null)
            {
                return Search(value, root.RightChild);
            }
            else if (value < root.Value && root.LeftChild != null)
            {
                return Search(value, root.LeftChild);
            }
            else return default(Node<int>);
        }
        /// <summary>
        /// Get an inner representation of the BST as an array of nodes
        /// </summary>
        /// <returns>Array of nodes</returns>
        public int[] ToArray()
        {
            _bt.InOrder(_bt.Root);
            return _bt.ToArray(); 
        }
    }
}
