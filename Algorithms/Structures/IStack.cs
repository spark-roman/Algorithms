using System;

namespace Algorithms.Structures
{
    public interface IStack<T>
    {
        bool IsEmpty();
        
        void Push(T item);

        T Pop();

        void Clear();

        int Size { get; }
    }
}
