using System;
using Tree.Classes;

namespace FizzBuzzTree
{
    class Program
    {
        /// <summary>
        /// Analyze tree for numbers divisible by 3, 5, 15
        /// </summary>
        /// <param name="bt">A tree to be analyzed</param>
        /// <returns>A string with tree mapped to Fizz, Buzz, FizzBuzz or the actual node value according to divisor (preorder traverse)</returns>
        public static string FizzBuzzTree(BinaryTree<int> bt)
        {
            string result = string.Empty;
            void Traverser(Node<int> root)
            {
                if (root.Value % 15 == 0) result += "FizzBuzz, ";
                else if (root.Value % 3 == 0) result += "Fizz, ";
                else if (root.Value % 5 == 0) result += "Buzz, ";
                else result +=  root.Value.ToString() + ", ";
                if (root.LeftChild != null) Traverser(root.LeftChild);
                if (root.RightChild != null) Traverser(root.RightChild);
            }
            Traverser(bt.Root);
            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            BinaryTree<int> bt = new BinaryTree<int>();
            bt.Add(3);
            bt.Add(5);
            bt.Add(15);
            bt.Add(4);
            bt.Add(82);
            Console.WriteLine(FizzBuzzTree(bt));
            Console.ReadLine();
        }
    }
}
