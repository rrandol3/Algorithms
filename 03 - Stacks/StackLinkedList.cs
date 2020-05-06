using _00___ADTs;
using System;
using System.Collections.Generic;
using System.Text;

namespace _03___Stacks
{
    public class StackLinkedList<T> : IStack<T>
    {
        LinkedList<T> list = new LinkedList<T>();
        public StackLinkedList() { }
        public bool IsEmpty()
        {
            return list.Count == 0;
        }

        public T Peek()
        {
            var last = list.Last;
            return last.Value;
        }

        public T Pop()
        {
            var last = list.Last;
            list.RemoveLast();
            return last.Value;
        }

        public void Push(T value)
        {
            list.AddLast(value);
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
