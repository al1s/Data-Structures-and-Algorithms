using System;
using Xunit;
using FizzBuzzTree;
using Tree.Classes;

namespace FizzBuzzTreeTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Test whether can traverse the tree with one divisible by 3 node's value
        /// </summary>
        [Fact]
        public void CanTraverseSingleElmTree()
        {
            BinaryTree<int> bt = new BinaryTree<int>();
            bt.Add(3);
            Assert.Equal("Fizz, ", Program.FizzBuzzTree(bt));
        }
        /// <summary>
        /// Test whether can traverse the tree with one non divisible by 3, 5, 15 node's value
        /// </summary>
        [Fact]
        public void CanTraverseSingleNonDivElmTree()
        {
            BinaryTree<int> bt = new BinaryTree<int>();
            bt.Add(4);
            Assert.Equal("4, ", Program.FizzBuzzTree(bt));
        }
        /// <summary>
        /// Test whether can traverse the tree with a mix of divisible and non-divisible3 nodes' values
        /// </summary>
        [Fact]
        public void CanTraverseMultiElmTree()
        {
            BinaryTree<int> bt = new BinaryTree<int>();
            bt.Add(3);
            bt.Add(5);
            bt.Add(15);
            bt.Add(4);
            bt.Add(82);
            Assert.Equal("Fizz, Buzz, 4, 82, FizzBuzz, ", Program.FizzBuzzTree(bt));
        }
    }
}
