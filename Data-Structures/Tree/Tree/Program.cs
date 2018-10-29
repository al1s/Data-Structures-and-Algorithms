using System;
using Tree.Classes;
using System.Collections.Generic;

namespace Tree
{
    class Program
    {
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
            Array.ForEach<Node<int>>(bT.ListResult.ToArray(), elm => Console.Write($"{elm.Value}, "));
            bT.ListResult = new List<Node<int>>();
            Console.WriteLine();
            Console.WriteLine("Inordered tree:");
            bT.InOrder(bT.Root);
            Array.ForEach<Node<int>>(bT.ListResult.ToArray(), elm => Console.Write($"{elm.Value}, "));
            bT.ListResult = new List<Node<int>>();
            Console.WriteLine();
            Console.WriteLine("Postordered tree:");
            bT.PostOrder(bT.Root);
            Array.ForEach<Node<int>>(bT.ListResult.ToArray(), elm => Console.Write($"{elm.Value}, "));
            Console.WriteLine();

        }
        static void BSTDemo()
        {
            BinarySearchTree<int> bst = new BinarySearchTree<int>(); 
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
            Array.ForEach(bst.ToArray(), elm => Console.Write($"{elm.Value}, "));
            bst.Search(45);
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
