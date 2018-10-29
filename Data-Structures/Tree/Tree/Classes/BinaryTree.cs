using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree<T>
    {
        /// <summary>
        /// Root of the binary tree
        /// </summary>
        public Node<T> Root = new Node<T>();
        /// <summary>
        /// Intermediary storage to output tree to array
        /// </summary>
        private List<Node<T>> _listResult = new List<Node<T>>();
        /// <summary>
        /// Empty binary tree constructor
        /// </summary>
        public BinaryTree()
        {
            Root = null;
        }
        /// <summary>
        /// Get first (breadth-first) node without any of leaves (or both)
        /// </summary>
        /// <returns>Node without a leaf</returns>
        public Node<T> FindNextAvailableRoot()
        {
            Queue<Node<T>> queue = new Queue<Node<T>>();
            Node<T> result = new Node<T>();
            queue.Enqueue(Root);
            while(queue.Count > 0)
            {
                Node<T> node = queue.Dequeue();
                if (node.LeftChild != null)
                {
                    queue.Enqueue(node.LeftChild);
                }
                else
                {
                    result = node;
                    break;
                }
                if (node.RightChild != null)
                {
                    queue.Enqueue(node.RightChild);
                }
                else
                {
                    result = node;
                    break;
                }
            }
            return result;
        }
        /// <summary>
        /// Add a value to the binary tree
        /// </summary>
        /// <param name="value">Value to be added</param>
        public void Add(T value)
        {
            if(Root == null)
            {
                Root = new Node<T>(value); 
            }
            else
            {
                Node<T> root = FindNextAvailableRoot();
                if (root.LeftChild == null) root.LeftChild = new Node<T>(value);
                else root.RightChild = new Node<T>(value);
            }
        }
        /// <summary>
        /// Add a value at a given position in the binary tree
        /// </summary>
        /// <param name="root">Root for the value to be added</param>
        /// <param name="position">Left or right leaf where the value to be added</param>
        /// <param name="value">The value to be added</param>
        public void AddAtPosition(Node<T> root, string position, T value)
        {
            Node<T> node = new Node<T>(value);
            if (position == "left") root.LeftChild = node;
            else if (position == "right") root.RightChild = node;
            else throw new Exception("Position should be either 'left' or 'right'");
        }
        /// <summary>
        /// Prepare intermediary representation of the BT in preorder traversal
        /// </summary>
        /// <param name="root">Node to start with</param>
        public void PreOrder(Node<T> root)
        {
            _listResult.Add(root);
            if (root.LeftChild != null) PreOrder(root.LeftChild);
            if (root.RightChild != null) PreOrder(root.RightChild);
        }
        /// <summary>
        /// Prepare intermediary representation of the BT in inorder traversal
        /// </summary>
        /// <param name="root">Node to start with</param>
        public void InOrder(Node<T> root)
        {
            if (root.LeftChild != null) InOrder(root.LeftChild);
            _listResult.Add(root);
            if (root.RightChild != null) InOrder(root.RightChild);
        }
        /// <summary>
        /// Prepare intermediary presentation of the BT in postorder traversal
        /// </summary>
        /// <param name="root">Node to start with</param>
        public void PostOrder(Node<T> root)
        {
            if (root.LeftChild != null) PostOrder(root.LeftChild);
            if (root.RightChild != null) PostOrder(root.RightChild);
            _listResult.Add(root);
        }
        /// <summary>
        /// Convert intermediary representation of the BT to an array (be default it uses inorder traversing
        /// </summary>
        /// <returns>Array of Nodes</returns>
        public T[] ToArray()
        {
            if (_listResult.Count == 0) InOrder(Root);
            List<Node<T>> _temp = _listResult;
            _listResult = new List<Node<T>>();
            T[] _tempValues = _temp.Select(x => x.Value).ToArray();
            return _tempValues;
        }
    }
}
