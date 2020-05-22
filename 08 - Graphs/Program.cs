using System;
using System.Collections.Generic;
using System.Text;

namespace _08___Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphEdgeList graph = new GraphEdgeList();
            graph.AddVertex('A');
            graph.AddVertex('B');
            graph.AddVertex('C');
            graph.AddVertex('D');
            graph.AddVertex('E');
            graph.AddEdge(0, 1);
            graph.AddEdge(1, 2);
            graph.AddEdge(0, 3);
            graph.AddEdge(3, 4);
            graph.DisplayEdges();
            graph.DFS();
            graph.BFS();
        }

       
    }
}
