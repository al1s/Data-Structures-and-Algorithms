using System;
using Xunit;
using MergeLL;
using LinkedList.Classes;

namespace MergeLLTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Check whether we can merge two lists, both are with equal length 
        /// </summary>
        [Fact]
        public void CanMergeListsEqualLength()
        {
            LList ll1 = new LList(new Node(10));
            LList ll2 = new LList(new Node("Ten"));
            ll1.Add(9);
            ll2.Add("Nine");
            LList result = Program.MergeLL(ll1, ll2);
            Assert.Equal(new object[] { 9, "Nine", 10, "Ten" }, result.ToArray());
        }
        /// <summary>
        /// Check whether we can merge two lists when the first is longer
        /// </summary>
        [Fact]
        public void CanMergeListsFirstLonger()
        {
            LList ll1 = new LList(new Node(10));
            LList ll2 = new LList(new Node("Ten"));
            ll1.Add(9);
            LList result = Program.MergeLL(ll1, ll2);
            Assert.Equal(new object[] { 9, "Ten", 10 }, result.ToArray());
        }

        /// <summary>
        /// Check whether we can merge two lists when the second is longer
        /// </summary>
        [Fact]
        public void CanMergeListsSecondLonger()
        {
            LList ll1 = new LList(new Node(10));
            LList ll2 = new LList(new Node("Ten"));
            ll2.Add("Nine");
            LList result = Program.MergeLL(ll1, ll2);
            Assert.Equal(new object[] { 10, "Nine", "Ten" }, result.ToArray());
        }
    }
}
