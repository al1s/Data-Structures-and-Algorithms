using System;
using Xunit;
using arrayBinarySearch;
using System.Linq;

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
        [InlineData(new int[] { 1, 2, 4, 5 }, 99, -1)]
        [InlineData(new int[] { 1, 2 }, 99, -1)]
        public void returnNegativeOneForNonexistingValue(int[] array, int number, int correctAnswer)
        {
            Assert.Equal(correctAnswer, Program.BinarySearch(array, number));
        }

        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5}, 4, 3)]
        [InlineData(new int[] { 1, 2, 4, 5 }, 4, 2)]
        [InlineData(new int[] { 1, 2, 4, 5 }, 1, 0)]
        [InlineData(new int[] { 1, 2 }, 1, 0)]
        [InlineData(new int[] { 1, 2 }, 2, 1)]
        [InlineData(new int[] { 99 }, 99, 0 )]
        public void returnPositionForExistingValue(int[] array, int number, int correctAnswer)
        {
            Assert.Equal(correctAnswer, Program.BinarySearch(array, number));
        }
        [Fact]
        public void performanceTest100Elements()
        {
            int[] array = Enumerable.Range(0, 100).Select(i => i).ToArray();
            Assert.Equal(10, Program.BinarySearch(array, 10));
        }
        [Fact]
        public void performanceTest10000Elements()
        {
            int[] array = Enumerable.Range(0, 10000).Select(i => i).ToArray();
            Assert.Equal(10, Program.BinarySearch(array, 10));
        }
        [Fact]
        public void performanceTest100000Elements()
        {
            int[] array = Enumerable.Range(0, 100000).Select(i => i).ToArray();
            Assert.Equal(10, Program.BinarySearch(array, 10));
        }
    }
}
