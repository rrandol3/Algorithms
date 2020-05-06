using _00___ADTs;
using System;
using System.Collections.Generic;
using System.Text;

namespace _06___Heaps
{
    public class Heap : IPriorityQueue
    {
        SortedSet<int> list;
        string heapType;
        int count;
        public Heap(string type)
        {
            list = new SortedSet<int>();
            heapType = type;
            count = 0;
        }
        public void Add(int value)
        {
            list.Add(value);
            count++;
        }

        public int Remove()
        {
            if (heapType == "max")
            {
                var max = list.Max;
                list.Remove(list.Max);
                count--;
                return max;
            }
            else
            {
                var min = list.Min;
                list.Remove(list.Min);
                count--;
                return min;
            }
        }

        public int Count()
        {
            return count;
        }
    }
}
