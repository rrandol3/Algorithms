using System;
using System.Collections.Generic;

namespace _15___Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 4, 3, 5, 9, 8, 10 };
            BinarySearchTree tree = new BinarySearchTree();
            for (int i = 0; i < arr.Length; i++)
            {
                tree.Add(arr[i]);
            }
            tree.InorderTraversal();
            Console.WriteLine();
            tree.PreorderTraversal();
            Console.WriteLine();
            tree.PostorderTraversal();
            Console.WriteLine();
            tree.BFS();
        }

        //Quick Sort
        public static void QuickSort(int[] arr, int low, int high)
        {
            if (low >= high)
            {
                return;
            }
            int pivot = low + (high - low) / 2;
            int index = Partition(arr, low, high, pivot);
            QuickSort(arr, low, index - 1);
            QuickSort(arr, index, high);
        }
        public static int Partition(int[] arr, int low, int high, int pivot)
        {
            while (low <= high)
            {
                while (arr[low] < arr[pivot])
                {
                    low++;
                }
                while (arr[high] > arr[pivot])
                {
                    high--;
                }
                if (low <= high)
                {
                    Swap(arr, low, high);
                    low++;
                    high--;
                }
            }
            return low;
        }
        public static void Swap(int[] arr, int a, int b)
        {
            var temp = arr[a];
            arr[a] = arr[b];
            arr[b] = temp;
         }
        //Merge Sort
        public static void MergeSort(int[] arr, int[] temp, int low, int high)
        {
            if (low >= high)
            {
                return;
            }
            int mid = low + (high - low) / 2;
            MergeSort(arr, temp, low, mid);
            MergeSort(arr, temp, mid + 1, high);
            Merge(arr, temp, low, mid, high);
        }
        public static void Merge(int[] arr, int[] temp, int low, int mid, int high)
        {
            int lowStart = low;
            int lowEnd = mid;
            int highStart = mid + 1;
            int highEnd = high;
            int i = low;
            while (lowStart <= lowEnd && highStart <= highEnd)
            {
                if (arr[lowStart] < arr[highStart])
                {
                    temp[i++] = arr[lowStart++];
                }
                else
                {
                    temp[i++] = arr[highStart++];
                }
            }
            while (lowStart <= lowEnd)
            {
                temp[i++] = arr[lowStart++];
            }
            while (highStart <= highEnd)
            {
                temp[i++] = arr[highStart++];
            }
            for (int j = low; j <= high; j++)
            {
                arr[j] = temp[j];
            }
        }
        //Binary Search
        public static int BinarySearch(int[] arr, int target)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (target == arr[mid])
                {
                    return mid;
                }
                else if (target < arr[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
        public static int BinarySearch(int[] arr, int low, int high, int target)
        {
            if (low > high)
            {
                return -1;
            }
            int mid = low + (high - low) / 2;
            if (target == arr[mid])
            {
                return mid;
            }
            else if (target < arr[mid])
            {
                return BinarySearch(arr, low, mid - 1, target);
            }
            else
            {
                return BinarySearch(arr, mid + 1, high, target);
            }
        }
    }

    //Linked List Node
    public class ListNode
    {
        public int Value { get; set; }
        public ListNode Next { get; set; }
        public ListNode(int value)
        {
            Value = value;
        }
    }
    //Linked List 
    public class LinkedList
    {
        ListNode head;
        public void AddFist(int value)
        {
            var newNode = new ListNode(value);
            if (head == null)
            {
                head = newNode;
            }
            else
            {
                var oldhead = head;
                head = newNode;
                head.Next = oldhead;
            }
        }
        public void AddLast(int value)
        {
            var newNode = new ListNode(value);
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
                ListNode prev = null;
                while (current.Next != null)
                {
                    prev = current;
                    current = current.Next;
                }
                prev.Next = null;
            }
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
    //Stack
    public class Stack
    {
        LinkedList<int> list;
        public Stack()
        {
            list = new LinkedList<int>();
        }

        public void Push(int value)
        {
            list.AddLast(value);
        }

        public int Pop()
        {
            var item = list.Last;
            list.RemoveLast();
            return item.Value;
        }
    }
    //Queue
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
            var item = list.First.Value;
            list.RemoveFirst();
            return item;
        }
    }
    //TreeNode
    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode Left { get; set; }
        public TreeNode Right { get; set; }
        public TreeNode(int value)
        {
            Value = value;
        }
    }
    //Binary Search Tree
    public class BinarySearchTree
    {
        TreeNode root;
        public void Add(int value)
        {
            root = Add(root, value);
        }
        public TreeNode Add(TreeNode node, int value)
        {
            if (node == null)
            {
                node = new TreeNode(value);
            }
            else
            {
                if (value < node.Value)
                {
                    if (node.Left != null)
                    {
                        node.Left = Add(node.Left, value);
                    }
                    else
                    {
                        node.Left = new TreeNode(value);
                    }
                }
                else
                {
                    if (node.Right != null)
                    {
                        node.Right = Add(node.Right, value);
                    }
                    else
                    {
                        node.Right = new TreeNode(value);
                    }
                }
            }
            return node;
        }
        public void InorderTraversal()
        {
            Console.Write("Inorder:" + " ");
            Inorder(root);
        }
        void Inorder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Inorder(node.Left);
            Console.Write(node.Value + " ");
            Inorder(node.Right);
        }
        public void PreorderTraversal()
        {
            Console.Write("Preorder:" + " ");
            Preorder(root);
        }
        void Preorder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Console.Write(node.Value + " ");
            Preorder(node.Left);
            Preorder(node.Right);
        }
        public void PostorderTraversal()
        {
            Console.Write("Postorder:" + " ");
            Postorder(root);
        }
        void Postorder(TreeNode node)
        {
            if (node == null)
            {
                return;
            }
            Postorder(node.Left);
            Postorder(node.Right);
            Console.Write(node.Value + " ");
        }
        public void BFS()
        {
            Console.Write("BFS: ");
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while (queue.Count > 0)
            {
                int level = queue.Count;
                for (int i = 0; i < level; i++)
                {
                    var currNode = queue.Dequeue();
                    Console.Write(currNode.Value + " ");
                    if (currNode.Left != null)
                    {
                        queue.Enqueue(currNode.Left);
                    }
                    if (currNode.Right != null)
                    {
                        queue.Enqueue(currNode.Right);
                    }
                }
            }
        }
    }

    //Vertex
    public class Vertex
    {
        public char Label { get; set; }
        public bool Visited { get; set; }
        public Vertex(char label)
        {
            Label = label;
        }
    }
    //Graph, matrix based, undirected
    public class Graph
    {
        int maxVertex;
        int vertexCount;
        Vertex[] vertexList;
        int[,] edgeList;
        Stack<int> stack;
        Queue<int> queue;
        public Graph()
        {
            maxVertex = 5;
            vertexCount = 0;
            vertexList = new Vertex[maxVertex];
            edgeList = new int[maxVertex, maxVertex];
            stack = new Stack<int>();
            queue = new Queue<int>();
        }
        public void AddVertex(char label)
        {
            vertexList[vertexCount++] = new Vertex(label);
        }
        public void AddEdge(int start, int end)
        {
            edgeList[start, end] = 1;
            edgeList[end, start] = 1;
        }

        public void DFS()
        {
            Console.WriteLine("DFS:");
            DisplayVertex(0);
            vertexList[0].Visited = true;
            stack.Push(0);
            while (stack.Count > 0)
            {
                var adjVertext = GetAdjUnvisitedVertex(stack.Peek());
                if (adjVertext == -1)
                {
                    stack.Pop();
                }
                else
                {
                    DisplayVertex(adjVertext);
                    vertexList[adjVertext].Visited = true;
                    stack.Push(adjVertext);
                }
            }
            ClearVertextList();
        }

        public void BFS()
        {
            Console.WriteLine("BFS:");
            DisplayVertex(0);
            vertexList[0].Visited = true;
            queue.Enqueue(0);
            int v2;
            while (queue.Count > 0)
            {
                int v1 = queue.Dequeue();
                while ((v2 = GetAdjUnvisitedVertex(v1)) != -1)
                {
                    DisplayVertex(v2);
                    vertexList[v2].Visited = true;
                    queue.Enqueue(v2);
                }
            }
            ClearVertextList();
        }

        int GetAdjUnvisitedVertex(int vertex)
        {
            for (int i = 0; i < vertexCount; i++)
            {
                if (edgeList[vertex, i] == 1 && vertexList[i].Visited == false)
                {
                    return i;
                }
            }
            return -1;
        }

        void ClearVertextList()
        {
            for (int i = 0; i < vertexCount; i++)
            {
                vertexList[i].Visited = false;
            }
        }

        void DisplayVertex(int vertex)
        {
            Console.Write(vertexList[vertex].Label + " ");
        }

        public void DisplayGraph()
        {
            for (int i = 0; i < maxVertex; i++)
            {
                for (int j = 0; j < maxVertex; j++)
                {
                    Console.Write(edgeList[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
    //Graph, array or arrays based, undirected
    public class GraphArray
    {
        int maxVertex;
        int vertexCount;
        Vertex[] vertexList;
        List<LinkedList<int>> edgeList;
        Stack<int> stack;
        Queue<int> queue;
        public GraphArray()
        {
            maxVertex = 5;
            vertexCount = 0;
            vertexList = new Vertex[maxVertex];
            edgeList = new List<LinkedList<int>>();
            stack = new Stack<int>();
            queue = new Queue<int>();
            for (int i = 0; i < maxVertex; i++)
            {
                edgeList.Add(new LinkedList<int>());
            }
        }
        public void AddVertex(char label)
        {
            vertexList[vertexCount++] = new Vertex(label);
        }
        public void AddEdge(int start, int end)
        {

            edgeList[start].AddLast(end);
            edgeList[end].AddLast(start);
        }

        public void DFS()
        {
            Console.WriteLine("DFS:");
            DisplayVertex(0);
            vertexList[0].Visited = true;
            stack.Push(0);
            while (stack.Count > 0)
            {
                var adjVertext = GetAdjUnvisitedVertex(stack.Peek());
                if (adjVertext == -1)
                {
                    stack.Pop();
                }
                else
                {
                    DisplayVertex(adjVertext);
                    vertexList[adjVertext].Visited = true;
                    stack.Push(adjVertext);
                }
            }
            ClearVertextList();
        }

        public void BFS()
        {
            Console.WriteLine("BFS:");
            DisplayVertex(0);
            vertexList[0].Visited = true;
            queue.Enqueue(0);
            int v2;
            while (queue.Count > 0)
            {
                int v1 = queue.Dequeue();
                while ((v2 = GetAdjUnvisitedVertex(v1)) != -1)
                {
                    DisplayVertex(v2);
                    vertexList[v2].Visited = true;
                    queue.Enqueue(v2);
                }
            }
            ClearVertextList();
        }

        int GetAdjUnvisitedVertex(int vertex)
        {
            foreach (var edge in edgeList[vertex])
            {
                if (vertexList[edge].Visited == false)
                {
                    return edge;
                }
            }
            return -1;
        }

        void ClearVertextList()
        {
            for (int i = 0; i < vertexCount; i++)
            {
                vertexList[i].Visited = false;
            }
        }

        void DisplayVertex(int vertex)
        {
            Console.Write(vertexList[vertex].Label + " ");
        }

        public void DisplayGraph()
        {
            foreach (var vertex in edgeList)
            {
                foreach (var item in vertex)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
