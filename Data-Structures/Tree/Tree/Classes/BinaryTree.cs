using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinaryTree<T>
    {
        public Node<T> Root = new Node<T>();
        public List<Node<T>> ListResult = new List<Node<T>>();

        public BinaryTree()
        {
            Root = null;
        }
        private Node<T> FindNextAvailableRoot()
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
        public void AddAtPosition(Node<T> root, string position, T value)
        {
            Node<T> node = new Node<T>(value);
            if (position == "left") root.LeftChild = node;
            else if (position == "right") root.RightChild = node;
            else throw new Exception("Position should be either 'left' or 'right'");
        }
        public void PreOrder(Node<T> root)
        {
            ListResult.Add(root);
            if (root.LeftChild != null) this.PreOrder(root.LeftChild);
            if (root.RightChild != null) this.PreOrder(root.RightChild);
        }
        public void InOrder(Node<T> root)
        {
            if (root.LeftChild != null) this.InOrder(root.LeftChild);
            ListResult.Add(root);
            if (root.RightChild != null) this.InOrder(root.RightChild);
        }
        public void PostOrder(Node<T> root)
        {
            if (root.LeftChild != null) this.PostOrder(root.LeftChild);
            if (root.RightChild != null) this.PostOrder(root.RightChild);
            ListResult.Add(root);
        }
    }
}
