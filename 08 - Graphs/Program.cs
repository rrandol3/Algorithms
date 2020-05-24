using System;
using System.Collections.Generic;
using System.Text;

namespace _08___Graphs
{
    class Program
    {
        static void Main(string[] args)
        {
            GraphMatrix graph = new GraphMatrix();
            graph.AddVertex('A');
            graph.AddVertex('B');
            graph.AddVertex('C');
            graph.AddVertex('D');
            graph.AddVertex('E');
            graph.AddEdge(0, 1);
            graph.AddEdge(1, 2);
            graph.AddEdge(0, 3);
            graph.AddEdge(3, 4);
            graph.DisplayGraph();
            //graph.DisplayEdges();
            graph.DFS();
            graph.DFSRec();
            graph.BFS();
            graph.ShowAllConnectionsTo('A');
        }
    }
}
