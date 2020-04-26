using System;

namespace Algorithms.Structures
{
    public class Stack<T> : IStack<T>
    {
        private T[] _stackArray;

        private int _size;
        public Stack()
        {
            _size = 0;
            _stackArray = new T[0];
        }

        public Stack(int capacity)
        {
            _size = 0;
            _stackArray = new T[capacity];
        }


        public int Size => throw new NotImplementedException();

        public void Clear()
        {
            Array.Clear(_stackArray, 0, _stackArray.Length);
            _size = 0;
        }

        public bool IsEmpty()
        {
            return _size == 0;
        }

        public T Pop()
        {
            if (_size == 0)
            {
                throw new InvalidOperationException("Stack is empty.");
            }

            var requestedValue = _stackArray[--_size];
            _stackArray[_size] = default(T);

            return requestedValue;
        }

        public void Push(T item)
        {
            ExtendStackIfIsFilled();

            _stackArray[_size++] = item;
        }

        private void ExtendStackIfIsFilled()
        {
            if (_stackArray.Length == _size)
            {
                var capacity = _stackArray.Length == 0 ? 16 : _stackArray.Length * 2;
                var buffer = new T[capacity];

                _stackArray.CopyTo(buffer, 0);
                _stackArray = buffer;
            }
        }
    }
}
