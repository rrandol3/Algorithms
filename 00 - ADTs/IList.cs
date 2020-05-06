using System;
using System.Collections.Generic;
using System.Text;

namespace _00___ADTs
{
    public interface IList<T>
    {
        void Add(T value);
        void Remove(int index);
        T Get(int index);
        int Size();
    }
}
