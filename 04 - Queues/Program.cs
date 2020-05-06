using System;
using System.Collections.Generic;

namespace _04___Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine(queue.Peek());
            Console.WriteLine();
            queue.Print();
            Console.WriteLine();
            queue.Dequeue();
            queue.Dequeue();
            queue.Print();
            
            //Console.WriteLine("Queue IsEmpty(): {0}", queue.IsEmpty());
            //Console.WriteLine("Dequeue: {0}", queue.Dequeue());
            //Console.WriteLine("Dequeue: {0}", queue.Dequeue());
            //Console.WriteLine("Dequeue: {0}", queue.Dequeue());
            //queue.Print();
            //Console.WriteLine("Queue IsEmpty(): {0}", queue.IsEmpty());
        }
    }

    public class Queue
    {
        LinkedList<int> list;
        public Queue()
        {
            list = new LinkedList<int>();
        }

        public void Enqueue(int value)
        {
            list.AddLast(value);
        }
        public int Dequeue()
        {
            var value = list.First.Value;
            list.RemoveFirst();
            return value;
        }
        public int Peek()
        {
            var value = list.First.Value;
            return value;
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
