using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hashtables.Classes
{
    public class Hashtable<T>
    {
        private int _numOfBuckets = 1024;
        private int _primeConst = 599;
        private LinkedList<Node<T>>[] _array;
        public Hashtable()
        {
            _array = new LinkedList<Node<T>>[_numOfBuckets];
        }
        public int GetHash(string key)
        {
            return Encoding.ASCII.GetBytes(key).Select(k => k * _primeConst).Sum() / _numOfBuckets;
        }
        public void Add(Node<T> node)
        {
            int bucketPosition = GetHash(node.Key);
            if (_array[bucketPosition] == null)
            {
                _array[bucketPosition] = new LinkedList<Node<T>>();
                _array[bucketPosition].AddLast(node);
            }
            else
            {
                foreach (Node<T> existingNode in _array[bucketPosition])
                {
                if (existingNode.Key == node.Key)
                    throw new Exception("The node already exists for the key");
                }
                _array[bucketPosition].AddLast(node);
            }

        }
        public Node<T> Find(string key)
        {
            int bucketPosition = GetHash(key);
            foreach (Node<T> item in _array[bucketPosition])
            {
                if (item.Key == key) return item;
            }
            return default(Node<T>);
        }
    }
}
