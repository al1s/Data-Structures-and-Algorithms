using System;
using Stack_and_Queue.Classes;

namespace queueWithStacks.Classes
{
    class Queue
    {
        private Stack _storage = default(Stack);
        private Stack _outputBuffer = default(Stack);
        public Queue(Node node)
        {
            _storage.Push(node);
        }
        public void Enqueue(Node node)
        {
            _storage.Push(node);
        }
        public Node Dequeue()
        {
            int cnt = 0;
            Node result = default(Node);
            Node _current = default(Node);
            _current = _storage.Pop();
            while (_current.Next != null)
            {
                _outputBuffer.Push(_current);
                _current = _storage.Pop();
                cnt += 1;
            }
            result = _storage.Pop();

            while (cnt >= 1)
            {
                _current = _outputBuffer.Pop();
                _storage.Push(_current);
                cnt -= 1;
            }
            return result; 
        }

    }
}
