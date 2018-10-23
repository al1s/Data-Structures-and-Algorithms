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
        /// Tests whether can enqueue and another element to the queue
        /// </summary>
        [Fact]
        public void CanEnqueueThirdElm()
        {
            Node nodeFirst = new Node("first");
            Node nodeSecond = new Node("second");
            Node nodeThird = new Node("third");
            QueueWithStacks queue = new QueueWithStacks(nodeFirst);
            queue.Enqueue(nodeSecond);
            queue.Enqueue(nodeThird);
            Assert.Equal(nodeFirst, queue.Peek());
            Assert.Equal(3, queue.Length);
        }
        /// <summary>
        /// Tests whether can dequeue one element from the queue
        /// </summary>
        [Fact]
        public void CanDequeueOneElm()
        {
            Node nodeFirst = new Node("first");
            QueueWithStacks queue = new QueueWithStacks(nodeFirst);
            Node firstResult = queue.Dequeue();
            Assert.Equal(nodeFirst, firstResult);
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
        /// <summary>
        /// Tests whether throws null reference exception when dequeue from the empty queue
        /// </summary>
        [Fact]
        public void GetExceptionNullPointerRetrievingEmptyQueue()
        {
            Node nodeFirst = new Node("first");
            QueueWithStacks queue = new QueueWithStacks(nodeFirst);
            queue.Dequeue();
            Assert.Throws<NullReferenceException>(() => queue.Dequeue());
        }
    }
}
