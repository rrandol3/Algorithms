using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace _08___Graphs
{
    class GraphAdjacencyList
    {
        protected int maxVerts;
        protected Vertex[] vertexList; //array of vertices
        protected int[][] adjList; //adjacency matrix
        protected int nVerts; //current number of vertices
        protected Stack<int> stack;
        protected Queue<int> queue;
        public GraphAdjacencyList()
        {
            maxVerts = 5;
            vertexList = new Vertex[maxVerts];
            adjList = new int[maxVerts][];
            nVerts = 0;
            stack = new Stack<int>();
            queue = new Queue<int>();
        }

        public void AddVertex(char label)
        {
            vertexList[nVerts] = new Vertex(label);
            nVerts++;
        }
        public virtual void AddEdge(int source, List<int> neighbors)
        {
            adjList[source] = new int[neighbors.Count];
            for (int i = 0; i < adjList[source].Length; i++)
            {
                adjList[source][i] = neighbors[i];
            }
        }

        public void DFS()
        {
            Console.WriteLine();
            Console.WriteLine("DFS:");
            vertexList[0].WasVisited = true;
            DisplayVertex(0);
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
                    vertexList[adjVertex].WasVisited = true;
                    DisplayVertex(adjVertex);
                    stack.Push(adjVertex);
                }
            }

            for (int i = 0; i < nVerts; i++)
            {
                vertexList[i].WasVisited = false;
            }

        }
        public void DFSRec()
        {
            Console.WriteLine();
            Console.WriteLine("DFSRec:");
            DFSRecHelper(0);
        }
        private void DFSRecHelper(int vertex)
        {
            if (vertexList[vertex].WasVisited == true)
            {
                return;
            }
            vertexList[vertex].WasVisited = true;
            DisplayVertex(vertex);

            for (int i = 0; i < adjList[vertex].Length; i++)
            {
                DFSRecHelper(adjList[vertex][i]);
            }
        }
        public void BFS()
        {
            Console.WriteLine();
            Console.WriteLine("BFS:");
            vertexList[0].WasVisited = true;
            DisplayVertex(0);
            queue.Enqueue(0);
            int v2;
            while (queue.Count > 0)
            {
                var v1 = queue.Dequeue();
                while ((v2 = GetAdjVertex(v1)) != -1)
                {
                    vertexList[v2].WasVisited = true;
                    DisplayVertex(v2);
                    queue.Enqueue(v2);
                }
            }

            for (int i = 0; i < nVerts; i++)
            {
                vertexList[i].WasVisited = false;
            }
        }
        protected int GetAdjVertex(int vertex)
        {
            foreach (var node in adjList[vertex])
            {
                if (vertexList[node].WasVisited == false)
                {
                    return node;
                }
            }
            return -1;
        }

        public void DisplayVertex(int v)
        {
            Console.Write(vertexList[v].Label + " ");
        }

        public void DisplayGraph()
        {
            for (int i = 0; i < adjList.Length; i++)
            {
                Console.Write($"{vertexList[i].Label}: ");
                foreach (var item in adjList[i])
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }
    }
}
