using System;
using Xunit;
using Tree;
using Tree.Classes;

namespace TreeTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Test whether we can get first available node without leaves
        /// </summary>
        [Fact]
        public void CanFindNextNodeWithoutLeaves()
        {
            BinaryTree<string> bt = new BinaryTree<string>();
            bt.Add("first");
            Assert.Equal(bt.Root, bt.FindNextAvailableRoot());
        }
        /// <summary>
        /// Test whether we can get first available node without right leaf
        /// </summary>
        [Fact]
        public void CanFindNextNodeWithoutRightLeaf()
        {
            BinaryTree<string> bt = new BinaryTree<string>();
            bt.Add("first");
            bt.Add("second");
            Assert.Equal(bt.Root, bt.FindNextAvailableRoot());
        }
        /// <summary>
        /// Test whether we can get first available node without left leaf
        /// </summary>
        [Fact]
        public void CanFindNextNodeWithoutLeftLeaf()
        {
            BinaryTree<string> bt = new BinaryTree<string>();
            bt.Add("first");
            bt.AddAtPosition(bt.Root, "right", "second");
            Assert.Equal(bt.Root.Value, bt.FindNextAvailableRoot().Value);
        }
        /// <summary>
        /// Test whether we can get first available node without leaves with a tree deeper than one level
        /// </summary>
        [Fact]
        public void CanFindNextNodeWithoutLeavesAfterRoot()
        {
            BinaryTree<string> bt = new BinaryTree<string>();
            bt.Add("first");
            bt.Add("second");
            bt.Add("third");
            Assert.NotEqual(bt.Root, bt.FindNextAvailableRoot());
        }
        /// <summary>
        /// Test whether we can add a left leaf
        /// </summary>
        [Fact]
        public void CanAddNodeAsLeftLeaf()
        {
            BinaryTree<string> bt = new BinaryTree<string>();
            bt.Add("first");
            bt.Add("second");
            bt.Add("third");
            Assert.Equal("second", bt.FindNextAvailableRoot().Value);
        }
        /// <summary>
        /// Test whether we can add a right leaf
        /// </summary>
        [Fact]
        public void CanAddNodeAsRightLeaf()
        {
            BinaryTree<string> bt = new BinaryTree<string>();
            bt.Add("first");
            bt.Add("second");
            bt.Add("third");
            bt.Add("forth");
            bt.Add("fifth");
            Assert.Equal("third", bt.FindNextAvailableRoot().Value);
        }
        /// <summary>
        /// Test whether we can get BT as a preorder traversed array
        /// </summary>
        [Fact]
        public void CanGetBTasPreorderedArray()
        {
            BinaryTree<string> bt = new BinaryTree<string>();
            bt.Add("first");
            bt.Add("second");
            bt.Add("third");
            bt.Add("forth");
            bt.Add("fifth");
            bt.Add("sixth");
            bt.Add("seventh");
            bt.PreOrder(bt.Root);
            string[] expectedResult = new string[] 
            {
                "first",
                "second",
                "forth",
                "fifth",
                "third",
                "sixth",
                "seventh",
            };
            Assert.Equal(expectedResult, bt.ToArray());
        }
        /// <summary>
        /// Test whether we can get BT as a inorder traversed array
        /// </summary>
        [Fact]
        public void CanGetBTasInorderedArray()
        {
            BinaryTree<string> bt = new BinaryTree<string>();
            bt.Add("first");
            bt.Add("second");
            bt.Add("third");
            bt.Add("forth");
            bt.Add("fifth");
            bt.Add("sixth");
            bt.Add("seventh");
            string[] expectedResult = new string[] 
            {
                "forth",
                "second",
                "fifth",
                "first",
                "sixth",
                "third",
                "seventh",
            };
            Assert.Equal(expectedResult, bt.ToArray());
        }
        /// <summary>
        /// Test whether we can get BT as a postorder traversed array
        /// </summary>
        [Fact]
        public void CanGetBTasPostorderedArray()
        {
            BinaryTree<string> bt = new BinaryTree<string>();
            bt.Add("first");
            bt.Add("second");
            bt.Add("third");
            bt.Add("forth");
            bt.Add("fifth");
            bt.Add("sixth");
            bt.Add("seventh");
            bt.PostOrder(bt.Root);
            string[] expectedResult = new string[] 
            {
                "forth",
                "fifth",
                "second",
                "sixth",
                "seventh",
                "third",
                "first",
            };
            Assert.Equal(expectedResult, bt.ToArray());
        }
        /// <summary>
        /// Check we can add value to BST and get it placed in the correct position
        /// </summary>
        [Fact]
        public void CanAddAValue()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(50);
            bst.Add(10);
            bst.Add(40);
            bst.Add(45);
            bst.Add(60);
            bst.Add(65);
            bst.Add(85);
            Assert.Equal(new int[] { 10, 40, 45, 50, 60, 65, 85 }, bst.ToArray());
        }
        /// <summary>
        /// Test whether can find the desired value in a BST
        /// </summary>
        /// <param name="valueToSearch"></param>
        [Theory]
        [InlineData(10)]
        [InlineData(45)]
        [InlineData(85)]
        [InlineData(50)]
        public void CanSearchForAValue(int valueToSearch)
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(50);
            bst.Add(10);
            bst.Add(40);
            bst.Add(45);
            bst.Add(60);
            bst.Add(65);
            bst.Add(85);
            Assert.Equal(valueToSearch, bst.Search(valueToSearch).Value);
        }
        // Test whether throws the certain exception if add existing value
        [Fact]
        public void ThrowIfAddExistingValue()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(50);
            Exception ex = Assert.Throws<Exception>(() => bst.Add(50));
            Assert.Equal("Can't insert the value: 50", ex.Message);
        }
        // Test whether get null when search for non-existing value
        [Fact]
        public void ThrowIfSearchNonExistingValue()
        {
            BinarySearchTree bst = new BinarySearchTree();
            bst.Add(1);
            Assert.Null(bst.Search(999));
        }
    }
}
