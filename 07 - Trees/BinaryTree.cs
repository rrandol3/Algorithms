using _00___ADTs;
using System;
using System.Collections.Generic;
using System.Text;

namespace _07___Trees
{
    public class BinaryTree : IBinaryTree
    {
        BinaryTreeNode root;
        Queue<BinaryTreeNode> queue;
        public BinaryTree()
        {
            root = null;
            queue = new Queue<BinaryTreeNode>();
        }
        public void Add(int value)
        {
            BinaryTreeNode newNode = new BinaryTreeNode(value);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                BinaryTreeNode current = root;
                BinaryTreeNode parent;
                while (true)
                {
                    parent = current;
                    if (newNode.Value < current.Value)
                    {
                        current = current.Left;
                        if (current == null)
                        {
                            parent.Left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        if (newNode.Value > current.Value)
                        {
                            current = current.Right;
                            if (current == null)
                            {
                                parent.Right = newNode;
                                return;
                            }
                        }
                    }
                }
            }
        }

        public void Remove(int value)
        {
            BinaryTreeNode current = root;
            BinaryTreeNode parent = root;
            bool isLeftChild = true;

            while (current.Value != value)
            {
                parent = current;
                if (value < current.Value)
                {
                    isLeftChild = true;
                    current = current.Left;
                }
                else
                {
                    isLeftChild = false;
                    current = current.Right;
                }

                if (current.Left == null && current.Right == null)
                {
                    if (current == root)
                    {
                        root = null;
                    }
                    else if (isLeftChild)
                    {
                        parent.Left = null;
                    }
                    else
                    {
                        parent.Right = null;
                    }
                }

                else if (current.Right == null)
                {
                    if (current == root)
                    {
                        root = current.Left;
                    }
                    else if (isLeftChild)
                    {
                        parent.Left = current.Left;
                    }
                    else
                    {
                        parent.Right = current.Left;
                    }
                }

                else if (current.Right == null)
                {
                    if (current == root)
                    {
                        root = current.Right;
                    }
                    else if (isLeftChild)
                    {
                        parent.Left = current.Right;
                    }
                    else
                    {
                        parent.Right = current.Right;
                    }
                }

                else
                {
                    BinaryTreeNode successor = GetSuccessor(current);

                    if ( current == root)
                    {
                        root = successor;
                    }
                    else if (isLeftChild)
                    {
                        parent.Left = successor;
                    }
                    else
                    {
                        parent.Right = successor;
                    }

                    successor.Left = current.Left;
                }
            }
        }

        private BinaryTreeNode GetSuccessor(BinaryTreeNode delNode)
        {
            BinaryTreeNode successorParent = delNode;
            BinaryTreeNode successor = delNode;
            BinaryTreeNode current = delNode.Right;
            while (current != null)
            {
                successorParent = successor;
                successor = current;
                current = current.Left;
            }
            if (successor != delNode.Right)
            {
                successorParent.Left = successor.Right;
                successor.Right = delNode.Right;
            }
            return successor;
        }

        public bool Search(int value)
        {
            var current = root;
            while (current.Value != value)
            {
                if (value < current.Value)
                {
                    current = current.Left;
                }
                else
                {
                    current = current.Right;
                }
                if (current == null)//end of traversal and no match was found
                {
                    return false;
                }
            }
            return current.Value == value;
        }

        public void Traverse(string type)
        {
            switch (type)
            {
                case "preorder":
                    PreorderTraversal(root);
                    break;
                case "inorder":
                    InorderTraversal(root);
                    break;
                case "postoder":
                    PostOrderTraveral(root);
                    break;
                default:
                    break;
            }
        }
        private void PreorderTraversal(BinaryTreeNode root)
        {
            if (root == null)
            {
                return;
            }
            Console.Write(root.Value + " ");
            PreorderTraversal(root.Left);
            PreorderTraversal(root.Right);
        }
        public void PreorderTraversalIterative()
        {
            Console.WriteLine();
            Stack<BinaryTreeNode> stack = new Stack<BinaryTreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                var currNode = stack.Pop();
                Console.Write(currNode.Value + " ");
                if (currNode.Right != null)
                {
                    stack.Push(currNode.Right);
                }
                if (currNode.Left != null)
                {
                    stack.Push(currNode.Left);
                }
            }
        }

        private void InorderTraversal(BinaryTreeNode root)
        {
            if (root == null)
            {
                return;
            }
            InorderTraversal(root.Left);
            Console.Write(root.Value + " ");
            InorderTraversal(root.Right);
        }

        public void InorderTraversalIterative()
        {
            Console.WriteLine();
            Stack<BinaryTreeNode> stack = new Stack<BinaryTreeNode>();
            BinaryTreeNode currNode = root;
            bool done = false;
            while (!done)
            {
                if (currNode != null)
                {
                    stack.Push(currNode);
                    currNode = currNode.Left;
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        done = false;
                    }
                    else
                    {
                        currNode = stack.Pop();
                        Console.Write(currNode.Value + " ");
                        currNode = currNode.Right;
                    }
                }
            }
        }

        private void PostOrderTraveral(BinaryTreeNode root)
        {
            if (root == null)
            {
                return;
            }
            PostOrderTraveral(root.Left);
            PostOrderTraveral(root.Right);
            Console.Write(root.Value + " ");
        }
        public void PostorderTraversalIterative()
        {
            Console.WriteLine();
            Stack<BinaryTreeNode> stack = new Stack<BinaryTreeNode>();
            BinaryTreeNode currNode = root;
            bool done = false;
            while (!done)
            {
                if (currNode != null)
                {
                    stack.Push(currNode);
                    currNode = currNode.Left;
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        done = false;
                    }
                    else
                    {
                        currNode = stack.Pop();
                        Console.Write(currNode.Value + " ");
                        currNode = currNode.Right;
                    }
                }
            }
        }
        public void BFS()
        {
            queue.Enqueue(root);
            while (queue.Count != 0)
            {
                var level = queue.Count;
                for (int i = 0; i < level; i++)
                {
                    var current = queue.Dequeue();
                    DisplayNodeValue(current);
                    if (current.Left != null)
                    {
                        queue.Enqueue(current.Left);
                    }
                    if (current.Right != null)
                    {
                        queue.Enqueue(current.Right);
                    }
                }
            }
        }

        private void DisplayNodeValue(BinaryTreeNode node)
        {
            Console.WriteLine(node.Value);
        }
    }
}
