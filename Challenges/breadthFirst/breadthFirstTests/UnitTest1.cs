using System;
using Xunit;
using Tree.Classes;
using System.Linq;
using breadthFirst;
using System.Diagnostics;

namespace breadthFirstTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Test we can traverse a tree with one element
        /// </summary>
        [Fact]
        public void CanTraverseTreeWithOneElm()
        {
            BinaryTree<int> bt = new BinaryTree<int>();
            bt.Add(2);
            Assert.Equal(2, Program.BreadthFirst(bt)[0]);
        }
        /// <summary>
        /// Test we can traverse a tree with many element
        /// </summary>
        [Fact]
        public void CanTraverseTreeWithManyElm()
        {
            BinaryTree<int> bt = new BinaryTree<int>();
            bt.Add(2);
            bt.Add(9);
            bt.Add(5);
            bt.Add(7);
            bt.Add(32);
            bt.Add(29);
            Assert.Equal(29, Program.BreadthFirst(bt)[5]);
        }
        /// <summary>
        /// Stress test 
        /// </summary>
        [Fact]
        public void StressTest()
        {
            Stopwatch stopwatch = new Stopwatch();
            BinaryTree<int> bt = new BinaryTree<int>();
            Enumerable.Range(1, 10000).ToList().ForEach(elm => bt.Add(elm));
            stopwatch.Start();
            Program.BreadthFirst(bt);
            stopwatch.Stop();
            Assert.InRange(stopwatch.ElapsedMilliseconds, 0, 1500);
        }
    }
}
