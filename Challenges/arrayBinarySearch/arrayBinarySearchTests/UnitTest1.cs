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
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5}, 4, 3)]
        public void returnPositionForExistingValue(int[] array, int number, int correctAnswer)
        {
            Assert.Equal(correctAnswer, Program.BinarySearch(array, number));
        }
    }
}
