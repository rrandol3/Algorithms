using _00___ADTs;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04___Queues
{
    public class QueueDynamicArray<T> : IQueue<T>
    {
        List<T> list = new List<T>();
        public QueueDynamicArray() { }
        public T Dequeue()
        {
            var first = list[0];
            list.RemoveAt(0);
            return first;
        }

        public void Enqueue(T value)
        {
            list.Add(value);
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }
    }
}
