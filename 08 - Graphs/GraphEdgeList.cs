using System;
using System.Collections.Generic;
using System.Text;

namespace _08___Graphs
{
    public class GraphEdgeList
    {
        protected int maxVerts;
        protected Vertex[] vertexList; //array of vertices
        protected int[][] edgeList; //adjaceny matrix
        protected int nVerts; //current number of vertices
        protected Stack<int> stack;
        protected Queue<int> queue;
        protected int maxEdges;
        protected int edgeCount;
        public GraphEdgeList()
        {
            maxEdges = 8;
            edgeCount = 0;
            maxVerts = 5;
            vertexList = new Vertex[maxVerts];
            edgeList = new int[maxEdges][];
            nVerts = 0;
            stack = new Stack<int>();
            queue = new Queue<int>();
            for (int i = 0; i < edgeList.Length; i++)
            {
                edgeList[i] = new int[2];
            }
        }
        public void AddVertex(char label)
        {
            vertexList[nVerts] = new Vertex(label);
            nVerts++;
        }

        public virtual void AddEdge(int start, int end)
        {
            edgeList[edgeCount++] = new int[] { start, end };
            edgeList[edgeCount++] = new int[] { end, start };
        }
        public void DFS()
        {
            Console.WriteLine("DFS:");
            DisplayVertex(0);
            vertexList[0].WasVisited = true;
            stack.Push(0);
            while (stack.Count > 0)
            {
                var adjVertex = GetUnvisitedAjVertex(stack.Peek());
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
            ClearVertexList();
        }
        public void DFSRec()
        {
            Console.WriteLine("DFS Recursion:");
            DFSRecHelper(0);
            ClearVertexList();
        }
        private void DFSRecHelper(int vertex)
        {

            DisplayVertex(vertex);
            vertexList[vertex].WasVisited = true;
            int v2;
            while ((v2 = GetUnvisitedAjVertex(vertex)) != -1)
            {
                DFSRecHelper(v2);
            }
        }
        public void BFS()
        {
            Console.WriteLine("BFS:");
            DisplayVertex(0);
            vertexList[0].WasVisited = true;
            queue.Enqueue(0);
            int v2;
            while (queue.Count > 0)
            {
                var v1 = queue.Dequeue();
                while ((v2 = GetUnvisitedAjVertex(v1)) != -1)
                {
                    DisplayVertex(v2);
                    vertexList[v2].WasVisited = true;
                    queue.Enqueue(v2);
                }
            }
            ClearVertexList();
        }
        void ClearVertexList()
        {
            Console.WriteLine();
            for (int i = 0; i < vertexList.Length; i++)
            {
                vertexList[i].WasVisited = false;
            }
        }
        int GetUnvisitedAjVertex(int vertex)
        {
            for (int i = 0; i < edgeList.Length; i++)
            {
                var adjVertex = edgeList[i][1];
                if (edgeList[i][0] == vertex && vertexList[adjVertex].WasVisited == false)
                {
                    return adjVertex;
                }
            }
            return -1;
        }
        public void DisplayVertex(int vertex)
        {
            Console.Write(vertexList[vertex].Label + " ");
        }
        public void DisplayEdges()
        {
            for (int i = 0; i < edgeList.Length; i++)
            {
                for (int j = 0; j < edgeList[i].Length; j++)
                {
                    DisplayVertex(edgeList[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
