using System;
using Xunit;
using fibonacciSequenceMember;

namespace fibonacciSequenceMemberTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(7, 13)]
        [InlineData(10, 55)]
        [InlineData(43, 433494437)]
        public void CanReturnNthElement(int positionOfMember, int expectedResult)
        {
            Assert.Equal(expectedResult, Program.FibonacciIterative(positionOfMember));
        }
        [Theory]
        [InlineData(3, 2)]
        [InlineData(4, 3)]
        [InlineData(5, 5)]
        [InlineData(7, 13)]
        [InlineData(10, 55)]
        // can't go up - performance degrade. To improve need to use memorization technique.
        public void CanReturnNthElementRecursive(int positionOfMember, int expectedResult)
        {
            Assert.Equal(expectedResult, Program.FibonacciRecursive(positionOfMember));
        }
    }
}
