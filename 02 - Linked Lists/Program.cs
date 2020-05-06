using System;

namespace _02___Linked_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListPractice list = new LinkedListPractice();
            //list.AddFirst(1);
            //list.AddFirst(2);
            //list.AddFirst(3);
            //list.AddFirst(4);

            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            list.AddLast(4);

            //list.AddAtIndex(99, 1);
            //list.RemoveAtIndex(1);
            list.Traversal();
            Console.WriteLine();
            list.Reverse();
            list.Traversal();
            //list.RemoveAtIndex(1);
            //list.ReverseList();
            //list.Remove(3);
            //list.Traversal();
            //Console.WriteLine("Number of items in the list: " + list.Count);
            //list.Remove(3);
            //list.Print();
        }
    }

    public class LinkedListNodePractice
    {
        public int Value { get; set; }
        public LinkedListNodePractice Next { get; set; }
        public LinkedListNodePractice(int value)
        {
            Value = value;
        }
    }

    public class LinkedListPractice
    {
        LinkedListNodePractice head;
        public void AddFirst(int value)
        {
            var newNode = new LinkedListNodePractice(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var oldHead = head;
                head = newNode;
                newNode.Next = oldHead;
            }
        }
        public void AddLast(int value)
        {
            var newNode = new LinkedListNodePractice(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }
        public void AddAtIndex(int value, int index)
        {
            var newNode = new LinkedListNodePractice(value);
            int indexCount = 0;
            var current = head;
            LinkedListNodePractice prev = null;
            while (current != null)
            {
                if (index == indexCount)
                {
                    //set temp to current
                    //set prev.next to newNode
                    //set newNode.next = temp
                    var temp = current;
                    prev.Next = newNode;
                    newNode.Next = temp;
                    return;
                }
                prev = current;
                current = current.Next;
                indexCount++;
            }
        }
        public void RemoveFirst()
        {
            if (head == null)
            {
                return;
            }
            else
            {
                head = head.Next;
            }
        }
        public void RemoveLast()
        {
            if (head == null)
            {
                return;
            }
            else
            {
                var current = head;
                LinkedListNodePractice prev = null;
                while (current.Next != null)
                {
                    prev = current;
                    current = current.Next;
                }
                prev.Next = null;
            }
        }
        public void RemoveAtIndex(int index)
        {
            int indexCount = 0;
            var current = head;
            LinkedListNodePractice prev = null;
            while (current != null)
            {
                if (indexCount == index)
                {
                    //set temp to current
                    //prev.Next = temp.Next
                    prev.Next = current.Next;
                    return;
                }
                prev = current;
                current = current.Next;
                indexCount++;
            }
        }
        public void Reverse()
        {
            var current = head;
            LinkedListNodePractice prev = null;
            while (current != null)
            {
                var temp = current.Next;
                current.Next = prev;
                prev = current;
                current = temp;
            }
            head = prev;
        }
        public void Traversal()
        {
            if (head == null)
            {
                return;
            }
            else
            {
                var current = head;
                while (current != null)
                {
                    Console.Write(current.Value + " ");
                    current = current.Next;
                }
            }
        }
    }

}
