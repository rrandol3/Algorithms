using System;
using System.Collections.Generic;
using System.Text;

namespace _00___ADTs
{
    public interface IBinaryTree
    {
        void Add(int value);
        void Remove(int value);
        bool Search(int value);
        void Traverse(string type);
    }
}
