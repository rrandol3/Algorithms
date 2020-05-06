﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _08___Graphs
{
    public class GraphList
    {
        int maxVerts = 20;
        Vertex[] vertexList; //array of vertices
        int nVerts; //current number of vertices
        protected List<LinkedList<int>> edgeList;
        Stack<int> stack;
        Queue<int> queue;
        public GraphList()
        {
            vertexList = new Vertex[maxVerts];
            nVerts = 0;
            edgeList = new List<LinkedList<int>>();
            stack = new Stack<int>();
            queue = new Queue<int>();
            for (int i = 0; i < maxVerts; i++)
            {
                edgeList.Add(new LinkedList<int>());
            }
        }

        public void AddVertex(char label)
        {
            vertexList[nVerts] = new Vertex(label);
            nVerts++;
        }

        public virtual void AddEdge(int start, int end)
        {
            edgeList[start].AddLast(end);
            edgeList[end].AddLast(start);
        }

        public void DisplayVertex(int v)
        {
            Console.WriteLine(vertexList[v].Label);
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

        private int GetAdjVertex(int vertex)
        {
            foreach (var item in edgeList[vertex])
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
