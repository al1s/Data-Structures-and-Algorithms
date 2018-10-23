using System;
using Xunit;
using Stack_and_Queue.Classes;

namespace Stack_and_QueueTests
{
    public class UnitTest1
    {
        /// <summary>
        /// Test whether can push to stack
        /// </summary>
        [Fact]
        public void CanPushNodeToStack()
        {
            Node nodeFirst = new Node("first");
            Stack stack = new Stack(nodeFirst );
            Assert.Equal(nodeFirst, stack.Peek());
            Node nodeSecond = new Node("second");
            stack.Push(nodeSecond);
            Assert.Equal(nodeSecond, stack.Peek());
            Node nodeThird = new Node("third");
            stack.Push(nodeThird);
            Assert.Equal(nodeThird, stack.Peek());
        }
        /// <summary>
        /// Test whether can pop from stack
        /// </summary>
        [Fact]
        public void CanPopNodeFromStack()
        {
            Node nodeFirst = new Node("first");
            Node nodeSecond = new Node("second");
            Node nodeThird = new Node("third");
            Stack stack = new Stack(nodeFirst );
            stack.Push(nodeSecond);
            stack.Push(nodeThird);
            Assert.Equal(nodeThird, stack.Pop());
        }
        /// <summary>
        /// Test whether can peek from stack
        /// </summary>
        [Fact]
        public void CanPeekNodeFromStack()
        {
            Node nodeFirst = new Node("first");
            Stack stack = new Stack(nodeFirst );
            Assert.Equal(nodeFirst, stack.Peek());
            Node nodeSecond = new Node("second");
            stack.Push(nodeSecond);
            Assert.Equal(nodeSecond, stack.Peek());
            Node nodeThird = new Node("third");
            stack.Push(nodeThird);
            Assert.Equal(nodeThird, stack.Peek());
        }
        /// <summary>
        /// Test whether can enqueue to queue
        /// </summary>
        [Fact]
        public void CanEnqueueNodeToQueue()
        {
            Node nodeFirst = new Node("first");
            Queue queue = new Queue(nodeFirst );
            Assert.Equal(nodeFirst, queue.GetTail());
            Node nodeSecond = new Node("second");
            queue.Enqueue(nodeSecond);
            Assert.Equal(nodeSecond, queue.GetTail());
            Node nodeThird = new Node("third");
            queue.Enqueue(nodeThird);
            Assert.Equal(nodeThird, queue.GetTail());

        }
        /// <summary>
        /// Test whether can dequeue from queue
        /// </summary>
        [Fact]
        public void CanDequeueNodeFromQueue()
        {
            Node nodeFirst = new Node("first");
            Node nodeSecond = new Node("second");
            Node nodeThird = new Node("third");
            Queue queue = new Queue(nodeFirst );
            queue.Enqueue(nodeSecond);
            queue.Enqueue(nodeThird);
            Assert.Equal(nodeFirst, queue.Dequeue());
            Assert.Equal(nodeSecond, queue.Dequeue());
            Assert.Equal(nodeThird, queue.Dequeue());

        }
        /// <summary>
        /// Test whether can peek from queue
        /// </summary>
        [Fact]
        public void CanPeekNodeToQueue()
        {
            Node nodeFirst = new Node("first");
            Queue queue = new Queue(nodeFirst );
            Assert.Equal(nodeFirst, queue.Peek());
            Node nodeSecond = new Node("second");
            queue.Enqueue(nodeSecond);
            Assert.Equal(nodeFirst, queue.Peek());
            Node nodeThird = new Node("third");
            queue.Enqueue(nodeThird);
            Assert.Equal(nodeFirst, queue.Peek());
        }
    }
}
