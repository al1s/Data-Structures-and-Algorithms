using System;
using Xunit;
using LinkedList.Classes;
using palindromeLinkedList;

namespace palindromeLinkedListTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Test the app returns true for real palindrome 
        /// </summary>
        [Fact]
        public void ReturnTrueForPalindrome()
        {
            LList ll = new LList(new Node(10));
            ll.Add(9);
            ll.Add(9);
            ll.Add(10);
            ll.Print();
            Assert.True(Program.CheckPalindrome(ll));
        }
        /// <summary>
        /// Test the app returns false if no real palindrome in linked list 
        /// </summary>
        [Fact]
        public void ReturnFalseForAbsentPalindrome()
        {
            LList ll = new LList(new Node(10));
            ll.Add(9);
            ll.Add(8);
            ll.Add(10);
            ll.Print();
            Assert.False(Program.CheckPalindrome(ll));
        }
    }
}
