using System;
using System.Collections.Generic;
using System.Text;

namespace _02___Linked_Lists
{
    public class DoublyLinkedListNode<T>
    {
        public T Value { get; set; }
        public DoublyLinkedListNode<T> Next { get; set; }
        public DoublyLinkedListNode<T> Previous { get; set; }
        public DoublyLinkedListNode() { }
        public DoublyLinkedListNode(T value)
        {
            Value = value;
        }
    }
}
