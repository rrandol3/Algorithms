using System;
using System.Collections.Generic;
using System.Text;

namespace _08___Graphs
{
    public class GraphList
    {
        int maxVerts = 20;
        Vertex[] vertexList; //array of vertices
        int nVerts; //current number of vertices
        protected List<LinkedList<int>> adjList;//can use generic list as well List<List<int>>
        Stack<int> stack;
        Queue<int> queue;
        public GraphList()
        {
            vertexList = new Vertex[maxVerts];
            nVerts = 0;
            adjList = new List<LinkedList<int>>();
            stack = new Stack<int>();
            queue = new Queue<int>();
            for (int i = 0; i < maxVerts; i++)
            {
                adjList.Add(new LinkedList<int>());
            }
        }

        public void AddVertex(char label)
        {
            vertexList[nVerts] = new Vertex(label);
            nVerts++;
        }

        public virtual void AddEdge(int start, int end)
        {
            adjList[start].AddLast(end);
            adjList[end].AddLast(start);
        }

        public void DisplayVertex(int v)
        {
            Console.Write(vertexList[v].Label + " ");
        }

        public void DFS()
        {
            Console.WriteLine("DFS:");
            vertexList[0].WasVisited = true;
            DisplayVertex(0);
            stack.Push(0);
            while (stack.Count != 0)
            {
                var adjVertex = GetUnvisitedAdjVertex(stack.Peek());
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
            ClearVertexList();
            Console.WriteLine();
        }
        private void DFSRecHelper(int vertex)
        {
            DisplayVertex(vertex);
            vertexList[vertex].WasVisited = true;
            foreach (var adjVertex in adjList[vertex])
            {
                if (vertexList[adjVertex].WasVisited == false)
                {
                    DFSRecHelper(adjVertex);
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
                while ((v2 = GetUnvisitedAdjVertex(v1)) != -1)
                {
                    vertexList[v2].WasVisited = true;
                    DisplayVertex(v2);
                    queue.Enqueue(v2);
                }
            }
            ClearVertexList();
            Console.WriteLine();
        }

        private void ClearVertexList()
        {
            for (int i = 0; i < nVerts; i++)
            {
                vertexList[i].WasVisited = false;
            }
        }

        private int GetUnvisitedAdjVertex(int vertex)
        {
            foreach (var item in adjList[vertex])
            {
                if (vertexList[item].WasVisited == false)
                {
                    return item;
                }
            }
            return -1;
        }
    }
}
