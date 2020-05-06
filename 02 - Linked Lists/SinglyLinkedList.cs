using System;
using System.Collections.Generic;
using System.Text;

namespace _02___Linked_Lists
{
    public class SinglyLinkedList<T> : _00___ADTs.IList<T>
    {
        SinglyLinkedListNode<T> head;
        int count;
        public SinglyLinkedList() { }
        public SinglyLinkedList(T value)
        {
            head = new SinglyLinkedListNode<T>(value);
            count = 0;
        }
        //Adds item to the front of list
        public void Add(T value)
        {
            SinglyLinkedListNode<T> newNode = new SinglyLinkedListNode<T>(value);
            var temp = head;
            head = newNode;
            newNode.Next = temp;
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
            try
            {
                var current = head;
                SinglyLinkedListNode<T> prev = null;
                int i = 0;
                if (index == 0)
                {
                    head = head.Next;
                    return;
                }
                while (current != null)
                {
                    if (i == index)
                    {
                        return;
                    }
                    prev = current;
                    current = current.Next;
                    i++;
                }
                prev.Next = current.Next;
                current.Next = null;
            }
            catch (Exception)
            {
                throw new ArgumentException("Index is out of range!");
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
