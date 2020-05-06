using System;
using System.Collections.Generic;

namespace _08___Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            //GraphPracticeList graph = new GraphPracticeList();
            GraphPractice graph = new GraphPractice();
            graph.AddVertex('A');
            graph.AddVertex('B');
            graph.AddVertex('C');
            graph.AddVertex('D');
            graph.AddVertex('E');

            graph.AddEdge(0, 1);
            graph.AddEdge(1, 2);
            graph.AddEdge(0, 3);
            graph.AddEdge(3, 4);

            //edges for mst
            //graph.AddEdge(0, 1);
            //graph.AddEdge(0, 2);
            //graph.AddEdge(0, 3);
            //graph.AddEdge(0, 4);
            //graph.AddEdge(1, 2);
            //graph.AddEdge(1, 3);
            //graph.AddEdge(1, 4);
            //graph.AddEdge(2, 3);
            //graph.AddEdge(2, 4);
            //graph.AddEdge(3, 4);

            //graph.DisplayGraph();
            //Console.WriteLine("Mst:");
            //graph.Mst();
            //graph.AddEdge(0, 1, 12);
            //graph.AddEdge(1, 2, 20);
            //graph.AddEdge(0, 3, 35);
            //graph.AddEdge(3, 4, 40);
            //graph.AddEdge(2, 3, 8);
            //graph.AddEdge(2, 4, 17);

            graph.DisplayGraph();

            Console.WriteLine();
            Console.WriteLine("Visits DFS:");
            graph.DFS();

            Console.WriteLine();
            Console.WriteLine("Visits BFS:");
            graph.BFS();

            //Console.WriteLine();
            //Console.WriteLine("Visits DFS Recursive:");
            //graph.DFSRecursion();

            //Console.WriteLine("Visits DFS:");
            //graph.DFS();
            //Console.WriteLine("Visits BFS:");
            //graph.BFS();
            //Console.WriteLine();
            //.DisplayGraph();
            //Console.WriteLine("Vertex Count:" + graph.VertexCount);
            //Console.WriteLine("Edge Count:" + graph.EdgeCount);
        }
    }

    public class GraphVertex
    {
        public char Label { get; set; }
        public bool WasVisited { get; set; }
        public GraphVertex(char label)
        {
            Label = label;
        }
    }

    public class GraphPractice
    {
        int maxVertices;
        int vertexCount;
        GraphVertex[] vertexList;
        int[,] edgeList;
        Stack<int> stack;
        Queue<int> queue;
        public GraphPractice()
        {
            maxVertices = 5;
            vertexCount = 0;
            vertexList = new GraphVertex[maxVertices];
            edgeList = new int[maxVertices, maxVertices];
            stack = new Stack<int>();
            queue = new Queue<int>();
        }

        public void AddVertex(char label)
        {
            vertexList[vertexCount] = new GraphVertex(label);
            vertexCount++;
        }

        public void AddEdge(int start, int end)
        {
            edgeList[start, end] = 1;
            edgeList[end, start] = 1;
        }

        public void DFS()
        {
            DisplayVertex(0);
            vertexList[0].WasVisited = true;
            stack.Push(0);
            while (stack.Count > 0)
            {
                var adjVertex = GetAdjVertex(stack.Peek());
                if (adjVertex == -1)
                {
                    stack.Pop();
                }
                else
                {
                    DisplayVertex(adjVertex);
                    vertexList[adjVertex].WasVisited = true;
                    stack.Push(adjVertex);
                }
            }
            for (int i = 0; i < vertexCount; i++)
            {
                vertexList[i].WasVisited = false;
            }
        }

        public void BFS()
        {
            DisplayVertex(0);
            vertexList[0].WasVisited = true;
            queue.Enqueue(0);
            int v2;
            while (queue.Count > 0)
            {
                int v1 = queue.Dequeue();
                while ((v2 = GetAdjVertex(v1)) != -1)
                {
                    DisplayVertex(v2);
                    vertexList[v2].WasVisited = true;
                    queue.Enqueue(v2);
                }
            }
            for (int i = 0; i < vertexCount; i++)
            {
                vertexList[i].WasVisited = false;
            }
        }

        int GetAdjVertex(int vertex)
        {
            for (int i = 0; i < vertexCount; i++)
            {
                if (edgeList[vertex, i] == 1 && vertexList[i].WasVisited == false)
                {
                    return i;
                }
            }
            return -1;
        }

        void DisplayVertex(int vertex)
        {
            Console.WriteLine(vertexList[vertex].Label);
        }

        public void DisplayGraph()
        {
            for (int i = 0; i < vertexCount; i++)
            {
                Console.Write(vertexList[i].Label + " ");
                for (int j = 0; j < vertexCount; j++)
                {
                    Console.Write(edgeList[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
