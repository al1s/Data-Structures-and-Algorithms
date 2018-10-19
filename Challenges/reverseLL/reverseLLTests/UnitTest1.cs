using System;
using Xunit;
using LinkedList.Classes;
using reverseLL;

namespace reverseLLTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Test whether we can reverse a linked list
        /// </summary>
        [Fact]
        public void CanReverseLinkedList()
        {
            LList llToReverse = new LList(new Node(10));
            llToReverse.Add(9);
            llToReverse.Add(8);
            llToReverse.Add(7);
            object[] expectedOrder = llToReverse.ToArray();
            Array.Reverse(expectedOrder);
            Assert.Equal(expectedOrder, Program.Reverse(llToReverse).ToArray());
        }
    }
}
