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
            if (_bt.Root == null) _bt.Add(value);
            else Add(value, _bt.Root);
        }
        public void Add(int value, Node<int> root)
        {
            if (value > root.Value)
                if (root.RightChild != null)
                {
                    Add(value, root.RightChild);
                }
                else
                {
                    _bt.AddAtPosition(root, "right", value);
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
                    _bt.AddAtPosition(root, "left", value);
                    return;
                }
            }
            else throw new Exception($"Can't insert the value: {value}");
        }
        public Node<T> Search(T value)
        {

            return default(Node<T>);
        }
    }
}
