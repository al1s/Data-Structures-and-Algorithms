using System;
using Xunit;
using Tree.Classes;
using findMaxValueTree;
using System.Diagnostics;
using System.Linq;

namespace findMaxValueTreeTests
{
    public class FindMaxTreeTests
    {
        /// <summary>
        /// Can return an integer given a binary tree
        /// </summary>
        [Fact]
        public void FindMaxValue_GivenATree_ReturnsAnInt()
        {
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Add(1);
            Assert.IsType<int>(Program.FindMaxValue(tree));
        }
        /// <summary>
        /// Can return max int value in a binary tree
        /// </summary>
        [Fact]
        public void FindMaxValue_GivenATree_ReturnsMaxValue()
        {
            int maxValue = 85;
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Add(10);
            tree.Add(1);
            tree.Add(20);
            tree.Add(31);
            tree.Add(15);
            tree.Add(45);
            tree.Add(maxValue);
            Assert.Equal(maxValue, Program.FindMaxValue(tree));
        }
        /// <summary>
        /// Can return max negative value of a binary tree
        /// </summary>
        [Fact]
        public void FindMaxValue_GivenATreeOfOneElm_ReturnsTheElementValue()
        {
            int maxValue = -85;
            BinaryTree<int> tree = new BinaryTree<int>();
            tree.Add(maxValue);
            Assert.Equal(maxValue, Program.FindMaxValue(tree));
        }
    }
}
