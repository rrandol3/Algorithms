using System;
using System.Collections.Generic;
using System.Text;

namespace _08___Graphs
{
    public class GraphMatrix
    {
        protected int maxVerts; 
        protected Vertex[] vertexList; //array of vertices
        protected int[,] adjMatrix; //adjaceny matrix
        protected int nVerts; //current number of vertices
        protected Stack<int> stack;
        protected Queue<int> queue;
        public GraphMatrix()
        {
            maxVerts = 5;
            vertexList = new Vertex[maxVerts];
            adjMatrix = new int [maxVerts, maxVerts];
            nVerts = 0;
            stack = new Stack<int>();
            queue = new Queue<int>();
        }

        public void AddVertex(char label)
        {
            vertexList[nVerts] = new Vertex(label);
            nVerts++;
        }

        public virtual void AddEdge(int start, int end)
        {
            adjMatrix[start, end] = 1;
            adjMatrix[end, start] = 1;
        }

        public void DFS()
        {
            Console.WriteLine("DFS:");
            vertexList[0].WasVisited = true;
            DisplayVertex(0);
            stack.Push(0);
            while (stack.Count != 0)
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

            ClearVertexList();
            Console.WriteLine();
        }
        public void DFSRec()
        {
            Console.WriteLine("DFS Recursion:");
            DFSRecHelper(0);
            Console.WriteLine();
            ClearVertexList();
        }
        private void DFSRecHelper(int vertex)
        {
            DisplayVertex(vertex);
            vertexList[vertex].WasVisited = true;
            for (int i = 0; i < vertexList.Length; i++)
            {
                if (adjMatrix[vertex, i] == 1 && vertexList[i].WasVisited == false)
                {
                    DFSRecHelper(i);
                }
            }
        }

        public void BFS()
        {
            Console.WriteLine("BFS:");
            vertexList[0].WasVisited = true;
            DisplayVertex(0);
            queue.Enqueue(0);
            int v2;
            while (queue.Count != 0)
            {
                int v1 = queue.Dequeue();
                while ((v2 = GetAdjVertex(v1)) != -1)
                {
                    vertexList[v2].WasVisited = true;
                    DisplayVertex(v2);
                    queue.Enqueue(v2);
                }
            }
            ClearVertexList();
            Console.WriteLine();
        }

        public void Mst()
        {
            vertexList[0].WasVisited = true;
            stack.Push(0);
            while (stack.Count > 0)
            {
                var currentVertex = stack.Peek();
                var adjVertex = GetAdjVertex(currentVertex);
                if (adjVertex == -1)
                {
                    stack.Pop();
                }
                else
                {
                    Console.WriteLine($"{vertexList[currentVertex].Label} to {vertexList[adjVertex].Label}");
                    vertexList[adjVertex].WasVisited = true;
                    stack.Push(adjVertex);
                }
            }

            for (int i = 0; i < nVerts; i++)
            {
                vertexList[i].WasVisited = false;
            }
        }

        protected int GetAdjVertex(int vertex)
        {
            for (int i = 0; i < nVerts; i++)
            {
                if (adjMatrix[vertex, i] == 1 && vertexList[i].WasVisited == false)
                {
                    return i;
                }
            }
            return -1;
        }

        void ClearVertexList()
        {
            Console.WriteLine();
            for (int i = 0; i < vertexList.Length; i++)
            {
                vertexList[i].WasVisited = false;
            }
        }

        public void DisplayVertex(int v)
        {
            Console.Write(vertexList[v].Label + " ");
        }

        public void ShowAllConnectionsTo(int vertex)
        {
            DisplayVertex(vertex);
            Console.Write(":");
            for (int i = 0; i < vertexList.Length; i++)
            {
                if (adjMatrix[vertex, i] == 1)
                {
                    DisplayVertex(i);
                }
            }
        }
        private int GetVertexLabelIndex(char label)
        {
            for (int i = 0; i < vertexList.Length; i++)
            {
                if (vertexList[i].Label == label)
                {
                    return i;
                }
            }
            return -1;
        }
        public void ShowAllConnectionsTo(char label)
        {
            var vertexIndex = GetVertexLabelIndex(label);
            DisplayVertex(vertexIndex);
            Console.Write(":");
            for (int i = 0; i < vertexList.Length; i++)
            {
                if (adjMatrix[vertexIndex, i] == 1)
                {
                    DisplayVertex(i);
                }
            }
        }

        public void DisplayGraph()
        {
            Console.Write("  ");
            for (int i = 0; i < vertexList.Length; i++)
            {
                Console.Write($"{vertexList[i].Label} ");
            }
            Console.WriteLine();
            for (int i = 0; i < maxVerts; i++)
            {
                Console.Write($"{vertexList[i].Label} ");
                for (int j = 0; j < maxVerts; j++)
                {
                    Console.Write($"{adjMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
