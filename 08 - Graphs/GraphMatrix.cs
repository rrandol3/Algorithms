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

            for (int i = 0; i < nVerts; i++)
            {
                vertexList[i].WasVisited = false;
            }

        }

        public void BFS()
        {
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

            for (int i = 0; i < nVerts; i++)
            {
                vertexList[i].WasVisited = false;
            }
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

        public void DisplayVertex(int v)
        {
            Console.WriteLine(vertexList[v].Label);
        }

        public void DisplayGraph()
        {
            for (int i = 0; i < maxVerts; i++)
            {
                Console.Write($"{vertexList[i].Label}: ");
                for (int j = 0; j < maxVerts; j++)
                {
                    Console.Write($"{adjMatrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
