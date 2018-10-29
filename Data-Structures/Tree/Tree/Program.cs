using System;
using Tree.Classes;
using System.Collections.Generic;

namespace Tree
{
    class Program
    {
        /// <summary>
        /// Demonstrate binary tree manipulations
        /// </summary>
        static void BinaryTreesDemo()
        {
            BinaryTree<int> bT = new BinaryTree<int>();
            bT.Add(0);
            bT.Add(1);
            bT.Add(2);
            bT.Add(3);
            bT.Add(4);
            bT.Add(5);
            bT.Add(6);
            Console.WriteLine("Preordered tree:");
            bT.PreOrder(bT.Root);
            Array.ForEach(bT.ToArray(), elm => Console.Write($"{elm}, "));
            Console.WriteLine();
            Console.WriteLine("Inordered tree:");
            bT.InOrder(bT.Root);
            Array.ForEach(bT.ToArray(), elm => Console.Write($"{elm}, "));
            Console.WriteLine();
            Console.WriteLine("Postordered tree:");
            bT.PostOrder(bT.Root);
            Array.ForEach(bT.ToArray(), elm => Console.Write($"{elm}, "));
            Console.WriteLine();

        }
        /// <summary>
        /// Demonstrate binary search tree abilities
        /// </summary>
        static void BSTDemo()
        {
            BinarySearchTree bst = new BinarySearchTree(); 
            bst.Add(50);
            bst.Add(30);
            bst.Add(70);
            bst.Add(10);
            bst.Add(5);
            bst.Add(7);
            bst.Add(40);
            bst.Add(45);
            bst.Add(80);
            Console.WriteLine("Binary search tree (as a sorted array):");
            Array.ForEach(bst.ToArray(), elm => Console.Write($"{elm}, "));
            bst.Search(999);
            try
            {
                bst.Add(40);
            }
            catch (Exception ex)
            {
                Console.WriteLine();
                Console.WriteLine(ex.Message);
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            BinaryTreesDemo();
            BSTDemo();
            Console.ReadLine();
        } 
    }
}
