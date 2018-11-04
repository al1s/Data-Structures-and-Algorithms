using System;
using Xunit;
using Tree.Classes;
using findMaxValueTree;

namespace findMaxValueTreeTests
{
    public class FindMaxTreeTests
    {
        [Fact]
        public void GiveTree_GetMaxValue()
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
    }
}
