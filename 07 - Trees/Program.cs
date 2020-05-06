using System;
using System.Collections.Generic;

namespace _07___Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(7);
            tree.Add(4);
            tree.Add(3);
            tree.Add(5);
            tree.Add(9);
            tree.Add(10);
            tree.Add(8);
            Console.WriteLine("Inorder Traveral:");
            tree.Traverse("inorder");
            //Console.WriteLine("Preorder Traveral:");
            //tree.Traverse("preorder");
            //Console.WriteLine("Postorder Traveral:");
            //tree.Traverse("postorder");
            //Console.WriteLine("Level Order Traveral:");
            //tree.Traverse("levelorder");
            //tree.PreorderTraversalIterative();
            tree.InorderTraversalIterative();
            //tree.Add(2);
            //tree.Add(3);
            //tree.Add(1);
            //tree.DFS();
            //tree.BFS();
            //tree.Remove(3);
            //tree.Traverse("preorder");
            //Console.WriteLine("Does tree contain 1:" + tree.Search(2));
            //tree.Traverse("preorder");
            //Console.WriteLine("BFS traversal:");
            //tree.BFS();
        }
    }

}
