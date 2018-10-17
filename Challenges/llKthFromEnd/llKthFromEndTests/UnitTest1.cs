using System;
using Xunit;
using llKthFromEnd;
using LinkedList.Classes;

namespace llKthFromEndTests
{
    public class UnitTest1
    {
        [Fact]
        public void ReturnHead()
        {
            Node node = new Node(10);
            LList ll = new LList(node);
            foreach (int item in new int[] { 9, 8, 7, 6 })
            {
                ll.Add(item);
            }
            Assert.Equal(6, Program.GetKthFromEnd(ll, 4));
        }
        [Fact]
        public void ReturnTail()
        {
            Node node = new Node(10);
            LList ll = new LList(node);
            foreach (int item in new int[] { 9, 8, 7, 6 })
            {
                ll.Add(item);
            }
            Assert.Equal(10, Program.GetKthFromEnd(ll, 0));
        }
        [Fact]
        public void ReturnArbitraryElm()
        {
            Node node = new Node(10);
            LList ll = new LList(node);
            foreach (int item in new int[] { 9, 8, 7, 6 })
            {
                ll.Add(item);
            }
            Assert.Equal(8, Program.GetKthFromEnd(ll, 2));
        }
        [Fact]
        public void ReturnExceptionForNonExistingElm()
        {
            Node node = new Node(10);
            LList ll = new LList(node);
            foreach (int item in new int[] { 9, 8, 7, 6 })
            {
                ll.Add(item);
            }
            Assert.Throws<IndexOutOfRangeException>(() => Program.GetKthFromEnd(ll, 14));
        }

    }
}
