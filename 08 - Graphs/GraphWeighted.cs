using System;
using System.Collections.Generic;
using System.Text;

namespace _08___Graphs
{
    public class GraphWeighted : GraphMatrix
    {
        public GraphWeighted() : base() { }
        public void AddEdge(int start, int end, int weight)
        {
            adjMatrix[start, end] = weight;
            adjMatrix[end, start] = weight;
        }
        public void MinimumSpanningTree()
        {

        }
    }

    public class VertexWeighted
    {
        char label;
        bool isInTree;
        public VertexWeighted(char lab)
        {
            label = lab;
            isInTree = false;
        }
    }

    public class Edge
    {
        int srcVert;
        int destVert;
        int distance;
        public Edge(int src, int dest, int dist)
        {
            srcVert = src;
            destVert = dest;
            distance = dist;
        }
    }
}
