using System;
using System.Collections.Generic;
using System.Text;

namespace _00___ADTs
{
    public interface IQueue<T>
    {
        void Enqueue(T value);
        T Dequeue();
        bool IsEmpty();
    }
}
