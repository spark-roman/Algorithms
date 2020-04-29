using System;

namespace Algorithms.Structures
{
    public class Queue<T>
    {
        private T[] _queueArray;

        private int _head;
        private int _tail;

        public Queue()
        {
            _queueArray = new T[0];
            _head = 0;
            _tail = 0;
        }

        public Queue(int capacity)
        {
            _queueArray = new T[capacity];
            _head = 0;
            _tail = 0;
        }

        public int Size => _tail - _head;
        public int Capacity => _queueArray.Length;  

        public void Clear()
        {
            Array.Clear(_queueArray, 0, _queueArray.Length);
            _head = 0;
            _tail = 0;
        }

        public bool IsEmpty()
        {
            return Size == 0;
        }

        public void Enqueue(T item)
        {
            ExtendQueueIfIsFilled();

            _queueArray[_tail++] = item;
        }

        public T Dequeue()
        {
            if (Size == 0)
            {
                throw new InvalidOperationException("Queue is empty.");
            }

            var requestedValue = _queueArray[_head];
            _queueArray[_head++] = default(T);

            return requestedValue;
        }

        private void ExtendQueueIfIsFilled()
        {
            if (_queueArray.Length == _tail)
            {
                var capacity = 0;

                if (_head == 0)
                {
                    capacity = _queueArray.Length == 0 ? 2 : _queueArray.Length * 2;
                }
                else if (_head > 0)
                {
                    capacity = _queueArray.Length;
                }

                var buffer = new T[capacity];
                Array.Copy(_queueArray, _head, buffer, 0, Size);
                _queueArray = buffer;

                _tail -= _head;
                _head = 0;
            }
        }
    }
}
