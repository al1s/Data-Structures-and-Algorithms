using System;
using Xunit;
using LinkedList;
using LinkedList.Classes;

namespace LinkedListTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanConverToArray()
        {
            Node node = new Node(10);
            LList ll = new LList(node);
            ll.Add(9);
            Assert.Equal(new object[] { 9, 10 }, ll.ToArray());
            
        }
        [Theory]
        [InlineData(9, new object[] {9, 10})]
        [InlineData(0, new object[] {0, 10})]
        [InlineData("dog", new object[] {"dog", 10})]
        public void canAddValues(object valueToAdd, object[] expectedResult)
        {
            Node node = new Node(10);
            LList ll = new LList(node);
            ll.Add(valueToAdd);
            Assert.Equal(expectedResult, ll.ToArray());
        }
        [Theory]
        [InlineData(9, new object[] {10, 9})]
        [InlineData(0, new object[] {10, 0})]
        [InlineData("dog", new object[] {10, "dog"})]
        public void canAppendValues(object valueToAdd, object[] expectedResult)
        {
            Node node = new Node(10);
            LList ll = new LList(node);
            ll.Append(valueToAdd);
            Assert.Equal(expectedResult, ll.ToArray());
        }
        [Theory]
        [InlineData("before", 10, new object[] {8, 9, "before", 10})]
        [InlineData("before", 8, new object[] {"before", 8, 9, 10})]
        [InlineData("before", 9, new object[] {8, "before", 9, 10})]
        public void canAddBefore(object valueToAdd, object valueAfter, object[] expectedResult)
        {
            Node node = new Node(10);
            LList ll = new LList(node);
            ll.Add(9);
            ll.Add(8);
            ll.AddBefore(new Node(valueAfter), valueToAdd);
            Assert.Equal(expectedResult, ll.ToArray());
        }
        [Theory]
        [InlineData("after", 9, new object[] {8, 9, "after", 10})]
        [InlineData("after", 8, new object[] {8, "after", 9, 10})]
        [InlineData("after", 10, new object[] {8, 9, 10, "after"})]
        public void canAddAfter(object valueToAdd, object valueAfter, object[] expectedResult)
        {
            Node node = new Node(10);
            LList ll = new LList(node);
            ll.Add(9);
            ll.Add(8);
            ll.AddAfter(new Node(valueAfter), valueToAdd);
            Assert.Equal(expectedResult, ll.ToArray());
        }
    }
}
