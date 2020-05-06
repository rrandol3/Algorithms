using System;
using System.Collections.Generic;

namespace _06___Heaps
{
    class Program
    {
        static void Main(string[] args)
        {
            HeapPractice heap = new HeapPractice("max");
            heap.Add(1);
            heap.Add(2);
            heap.Add(3);
            heap.Add(4);
            Console.WriteLine("Peek at the top:" + heap.Peek());
            var count = heap.Count;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(heap.Remove());
            }
        }
    }

    public class HeapPractice
    {
        SortedSet<int> list;
        public int Count { get; private set; }
        string heapType;
        public HeapPractice()
        {
            list = new SortedSet<int>();
            Count = 0;
        }
        public HeapPractice(string heapType)
        {
            list = new SortedSet<int>();
            Count = 0;
            this.heapType = heapType;
        }

        public void Add(int value)
        {
            list.Add(value);
            Count++;
        }

        public int Remove()
        {
            int item;
            if (heapType == "min")
            {
                item = list.Min;
            }
            else
            {
                item = list.Max;
            }
            list.Remove(item);
            Count--;
            return item;
        }

        public int Peek()
        {
            int item;
            if (heapType == "min")
            {
                item = list.Min;
            }
            else
            {
                item = list.Max;
            }
            return item;
        }
    }
}
