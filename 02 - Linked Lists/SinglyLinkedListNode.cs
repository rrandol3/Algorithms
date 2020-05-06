using System;
using System.Collections.Generic;
using System.Text;

namespace _02___Linked_Lists
{
    public class SinglyLinkedListNode<T>
    {
        public T Value { get; set; }
        public SinglyLinkedListNode<T> Next { get; set; }
        public SinglyLinkedListNode() { }
        public SinglyLinkedListNode(T value)
        {
            Value = value;
        }
    }
}
