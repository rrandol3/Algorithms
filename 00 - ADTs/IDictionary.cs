using System;
using System.Collections.Generic;
using System.Text;

namespace _00___ADTs
{
    public interface IDictionary<K, V>
    {
        void Add(K key, V value);
        void Remove(K key);
        bool Contains(K key);
        V Get(K Key);
    }
}
