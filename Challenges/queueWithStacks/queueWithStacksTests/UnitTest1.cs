using System;
using Xunit;
using Stack_and_Queue.Classes;
using queueWithStacks.Classes;

namespace queueWithStacksTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Tests whether can initialize the queue with the first element
        /// </summary>
        [Fact]
        public void CanInitializeWithFirstELm()
        {
            Node nodeFirst = new Node("first");
            QueueWithStacks queue = new QueueWithStacks(nodeFirst);
            Assert.Equal(nodeFirst, queue.Peek());
        }
        /// <summary>
        /// Tests whether can enqueue another element to the queue
        /// </summary>
        [Fact]
        public void CanEnqueueSecondElm()
        {
            Node nodeFirst = new Node("first");
            Node nodeSecond = new Node("second");
            QueueWithStacks queue = new QueueWithStacks(nodeFirst);
            queue.Enqueue(nodeSecond);
            Assert.Equal(nodeFirst, queue.Peek());
            Assert.Equal(2, queue.Length);
        }
        /// <summary>
        /// Tests whether can dequeue from the queue
        /// </summary>
        [Fact]
        public void CanDequeueTwoElm()
        {
            Node nodeFirst = new Node("first");
            Node nodeSecond = new Node("second");
            QueueWithStacks queue = new QueueWithStacks(nodeFirst);
            queue.Enqueue(nodeSecond);
            Node firstResult = queue.Dequeue();
            Node secondResult = queue.Dequeue();
            Assert.Equal(nodeFirst, firstResult);
            Assert.Equal(nodeSecond, secondResult);
        }
    }
}
