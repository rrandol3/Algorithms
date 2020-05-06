using System;
using System.Collections.Generic;

namespace _03___Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            StackPractice stack = new StackPractice();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Print();
            Console.WriteLine("Stack Peek(): {0}", stack.Peek());
            stack.Pop();
            stack.Pop();
            //stack.Pop();
            stack.Print();
            //Console.WriteLine("Stack isEmpty(): {0}", stack.IsEmpty());
            //stack.Print();
        }
    }

    public class StackPractice
    {
        LinkedList<int> list;
        public StackPractice()
        {
            list = new LinkedList<int>();
        }

        public void Push(int value)
        {
            list.AddLast(value);
        }

        public int Pop()
        {
            var value = list.Last.Value;
            list.RemoveLast();
            return value;
        }

        public int Peek()
        {
            var value = list.Last.Value;
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
