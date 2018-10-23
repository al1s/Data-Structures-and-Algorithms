using Stack_and_Queue.Classes;

namespace queueWithStacks.Classes
{
    /// <remarks>Queue implemented using two stacks: first as a main storage, second as a temporary. When retrieving head element:
    /// - move iteratively every element from the main storage to the temporary;
    /// - pop top element from the temporary stack to result variable;
    /// - move back iteratively every element from the temporary to the main storage;
    /// - return result.</remarks>
    public class QueueWithStacks
    {
        /// <summary>
        /// Storage stack for queue values
        /// </summary>
        private Stack _storage = new Stack(new Node(null));
        /// <summary>
        /// Temporary stack to store queue values while shifting data back and force
        /// </summary>
        private Stack _outputBuffer = new Stack(new Node(null));
        /// <summary>
        /// Queue head
        /// </summary>
        private Node _head = default(Node);
        /// <summary>
        /// Queue tail
        /// </summary>
        private Node _tail = default(Node);
        /// <summary>
        /// Queue length
        /// </summary>
        public int Length { get; private set; }
        /// <summary>
        /// Constructor for queue
        /// </summary>
        /// <param name="node">Initial content of the queue</param>
        public QueueWithStacks(Node node)
        {
            // get rid of initializing nulls in our inner storage stack
            _storage.Pop();
            // get rid of initializing nulls in our inner output stack
            _outputBuffer.Pop();
            _storage.Push(node);
            _head = node;
            _tail = node;
            Length += 1;
        }
        /// <summary>
        /// Add new element from the queue
        /// </summary>
        /// <param name="node">Element to be added to the queue</param>
        public void Enqueue(Node node)
        {
            _storage.Push(node);
            _tail = node;
            Length += 1;
        }
        /// <summary>
        /// Remove and return head element from the queue
        /// </summary>
        /// <returns>Element (head) to be returned</returns>
        public Node Dequeue()
        {
            int cnt = Length;
            Node result = default(Node);
            while (cnt > 0)
            {
                _outputBuffer.Push(_storage.Pop());
                cnt -= 1;
            }
            result = _outputBuffer.Pop();
            Length -= 1;
            while (cnt < Length)
            {
                if (cnt == 0)
                {
                    _head = _outputBuffer.Pop();
                    _storage.Push(_head);
                }
                else
                {
                    _storage.Push(_outputBuffer.Pop());
                }
                cnt += 1;
            }
            return result;
        }
        /// <summary>
        /// Return (without removal) head element from the queue
        /// </summary>
        /// <returns>Element (head) of the queue</returns>
        public Node Peek()
        {
            Node _temp = _head;
            _temp.Next = null;
            return _temp;
        }
        public override string ToString()
        {
            Node currentTop = _storage.Peek();
            string result = "null";
            if (currentTop == null) return "null";
            while (currentTop.Next != null)
            {
                result = $"{currentTop.Value} -> {result}";
                currentTop = currentTop.Next;
            }
            result = $"{currentTop.Value}(HEAD) -> {result}";
            return result;
        }

    }
}
