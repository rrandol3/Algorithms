using System;
using System.Collections.Generic;
using System.Text;

namespace _07___Trees
{
    public class BinaryTreeNode
    {
        public int Value { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }
        public BinaryTreeNode() { }
        public BinaryTreeNode(int value)
        {
            Value = value;
        }
    }
}
