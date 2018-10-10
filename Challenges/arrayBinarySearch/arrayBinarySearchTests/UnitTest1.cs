using System;
using Xunit;
using arrayBinarySearch;

namespace arrayBinarySearchTests
{
    public class UnitTest1
    {
        [Fact]
        public void returnsNegative1ForEmptyArray()
        {
            Assert.Equal(-1, Program.BinarySearch(new int[] { }, 1));
        }

        [Fact]
        public void returnsPositionForArrayWithOneElement()
        {
            Assert.Equal(0, Program.BinarySearch(new int[] { 1 }, 1));
        }
        [Fact]
        public void returnsPositionForArrayWithOneElementForNonExistentValue()
        {
            Assert.Equal(-1, Program.BinarySearch(new int[] { 1 }, 2));
        }
    }
}
