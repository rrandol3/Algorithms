using System;
using System.Collections.Generic;
using System.Text;

namespace _02___Linked_Lists
{
    public class DoublyLinkedList<T> : _00___ADTs.IList<T>
    {
        DoublyLinkedListNode<T> head;
        int count;
        public DoublyLinkedList()
        {
            head = new DoublyLinkedListNode<T>();
            count = 0;
        }
        public DoublyLinkedList(T value)
        {
            head = new DoublyLinkedListNode<T>(value);
            count = 0;
        }
        //Add at the front of list
        public void Add(T value)
        {
            DoublyLinkedListNode<T> newNode = new DoublyLinkedListNode<T>(value);
            var oldHead = head;//old head
            head = newNode;//set head reference to newNode
            newNode.Next = oldHead;//attach next pointer to old head
            oldHead.Previous = newNode;//set old head prev to newNode
            count++;
        }

        public T Get(int index)
        {
            try
            {
                var current = head;
                int i = 0;
                while (current != null)
                {
                    if (i == index)
                    {
                        break;
                    }
                    current = current.Next;
                    i++;
                }
                return current.Value;
            }
            catch (Exception)
            {

                throw new ArgumentException("Index is out of range!");
            }
        }

        public void Remove(int index)
        {
            if (index == 0)
            {
                head = head.Next;
                head.Previous = null;
                return;
            }
            var current = head;
            int i = 0;
            while (current != null)
            {
                if (i == index)
                {
                    break;
                }
                current = current.Next;
                i++;
            }
            var prev = current.Previous;
            var next = current.Next;
            current.Next = null;
            current.Previous = null;
            prev.Next = next;
            if (index == count - 1)
            {
                next.Previous = prev;
            }
        }

        public int Size()
        {
            return count;
        }

        public void Print()
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
