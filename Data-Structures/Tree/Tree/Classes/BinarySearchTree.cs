using System;
using System.Collections.Generic;
using System.Text;

namespace Tree.Classes
{
    public class BinarySearchTree<T>
    {
        public BinaryTree<int> _bt { get; set; }
        public BinarySearchTree()
        {
            _bt = new BinaryTree<int>();
        }
        public void Add(int value)
        {
            this.Add(value, _bt.Root);
        }
        public void Add(int value, Node<int> root)
        {
            if(root == null)
            {
                root = new Node<int>(value);
            }
            if(value > root.Value)
            {
                this.Add(value, root.RightChild);
            }
            else if(value < root.Value)
            {
                this.Add(value, root.LeftChild);
            }
        }
        public Node<T> Search(T value)
        {

            return default(Node<T>);
        }
    }
}
