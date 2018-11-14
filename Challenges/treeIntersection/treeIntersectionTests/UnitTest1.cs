using System;
using Xunit;
using Tree.Classes;
using System.Collections.Generic;
using treeIntersection;

namespace treeIntersectionTests
{
    public class UnitTest1
    {
        [Fact]
        public void GivenTreesWithIntersection_ReturnsIntersection()
        {
            // arrange
            BinaryTree<int> binaryTree1 = new BinaryTree<int>();
            BinaryTree<int> binaryTree2 = new BinaryTree<int>();
            List<int> expectedIntersection = new List<int>(new int[]{ 1, 2 });
            // act
            binaryTree1.Add(30);
            binaryTree1.Add(20);
            binaryTree1.Add(expectedIntersection[0]);
            binaryTree1.Add(expectedIntersection[1]);

            binaryTree2.Add(10);
            binaryTree2.Add(12);
            binaryTree2.Add(17);
            binaryTree2.Add(7);
            binaryTree2.Add(expectedIntersection[0]);
            binaryTree2.Add(expectedIntersection[1]);
            List<int> actualResult = Program.TreeIntersection(binaryTree1, binaryTree2);
            // assert
            Assert.Equal(expectedIntersection, actualResult);

        }
        [Fact]
        public void GivenTreesWithoutIntersection_ReturnsNull()
        {
            // arrange
            BinaryTree<int> binaryTree1 = new BinaryTree<int>();
            BinaryTree<int> binaryTree2 = new BinaryTree<int>();
            List<int> expectedEmptyIntersection = new List<int>();
            // act
            binaryTree1.Add(30);
            binaryTree1.Add(20);
            binaryTree2.Add(1);
            binaryTree2.Add(2);
            // assert
            List<int> actualResult = Program.TreeIntersection(binaryTree1, binaryTree2);
            // assert
            Assert.Equal(expectedEmptyIntersection, actualResult);

        }
    }
}
