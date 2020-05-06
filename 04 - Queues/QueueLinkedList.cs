using _00___ADTs;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04___Queues
{
    public class QueueLinkedList<T> : IQueue<T>
    {
        LinkedList<T> list = new LinkedList<T>();
        public QueueLinkedList() { }
        public T Dequeue()
        {
            var first = list.First;
            list.RemoveFirst();
            return first.Value;
        }

        public void Enqueue(T value)
        {
            list.AddLast(value);
        }

        public bool IsEmpty()
        {
            return list.Count == 0;
        }
    }
}
