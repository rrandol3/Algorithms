using _00___ADTs;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03___Stacks
{
    public class StackDynamicArray<T> : IStack<T>
    {
        List<T> list = new List<T>();
        public StackDynamicArray() { }
        public bool IsEmpty()
        {
            return list.Count == 0;
        }

        public T Peek()
        {
            var last = list[list.Count - 1];
            return last;
        }

        public T Pop()
        {
            var last = list[list.Count - 1];
            list.RemoveAt(list.Count - 1);
            return last;
        }

        public void Push(T value)
        {
            list.Add(value);
        }

        public void Print()
        {
            foreach (var item in list)
            {
                Console.Write(item + " ");
            }
        }
    }
}
