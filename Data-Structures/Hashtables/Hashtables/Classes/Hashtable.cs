using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hashtables.Classes
{
    public class Hashtable<T>
    {
        private readonly int _numOfBuckets = 1024;
        private readonly int _primeConst = 599;
        private LinkedList<Node<T>>[] _array;
        /// <summary>
        ///  Reserve a memory for a new hashtable
        /// </summary>
        public Hashtable()
        {
            _array = new LinkedList<Node<T>>[_numOfBuckets];
        }
        /// <summary>
        /// Get hash value for a string: convert each character to ASCII code, multiply by prime number, get the sum of all characters and divide it by the number of buckets
        /// </summary>
        /// <param name="key">String to get the hash for</param>
        /// <returns>Numeric hash value</returns>
        public int GetHash(string key)
        {
            return Encoding.ASCII.GetBytes(key).Select(k => k * _primeConst).Sum() / _numOfBuckets;
        }
        /// <summary>
        /// Add new node (consists of key, value pair) to the hashtable
        /// </summary>
        /// <param name="node">Node to be added</param>
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
                    {
                        throw new Exception("The node already exists for the key");
                    }
                }
                _array[bucketPosition].AddLast(node);
            }

        }
        /// <summary>
        /// Find a node for a given key
        /// </summary>
        /// <param name="key">Search key</param>
        /// <returns>Node with a given key</returns>
        public Node<T> Find(string key)
        {
            int bucketPosition = GetHash(key);
            if (_array[bucketPosition] == null)
                return default(Node<T>);
            foreach (Node<T> item in _array[bucketPosition])
            {
                if (item.Key == key)
                {
                    return item;
                }
            }
            return default(Node<T>);
        }
        public bool Contains(string key)
        {
            if (Find(key) != null)
                return true;
            return false;
        }
    }
}
