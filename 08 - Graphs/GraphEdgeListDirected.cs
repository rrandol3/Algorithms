using System;
using System.Collections.Generic;
using System.Text;

namespace _08___Graphs
{
    public class GraphEdgeListDirected : GraphEdgeList
    {
        public override void AddEdge(int start, int end)
        {
            edgeList[edgeCount++] = new int[] { start, end };
        }
    }
}
