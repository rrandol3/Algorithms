using System;
using System.Collections.Generic;
using System.Text;

namespace _00___ADTs
{
    public interface IStack<T>
    {
        void Push(T value);
        T Pop();
        T Peek();
        bool IsEmpty();
    }
}
