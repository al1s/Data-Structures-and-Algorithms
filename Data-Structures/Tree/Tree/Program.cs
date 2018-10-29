using System;
using Tree.Classes;
using System.Collections.Generic;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
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
            Array.ForEach<Node<int>>(bT.arrayResult.ToArray(), elm => Console.Write($"{elm.Value}, "));
            bT.arrayResult = new List<Node<int>>();
            Console.WriteLine();
            Console.WriteLine("Inordered tree:");
            bT.InOrder(bT.Root);
            Array.ForEach<Node<int>>(bT.arrayResult.ToArray(), elm => Console.Write($"{elm.Value}, "));
            bT.arrayResult = new List<Node<int>>();
            Console.WriteLine();
            Console.WriteLine("Postordered tree:");
            bT.PostOrder(bT.Root);
            Array.ForEach<Node<int>>(bT.arrayResult.ToArray(), elm => Console.Write($"{elm.Value}, "));
            Console.ReadLine();
        } 
    }
}
