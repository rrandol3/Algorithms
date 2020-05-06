using System;
using System.Collections.Generic;
using System.Text;

namespace _08___Graphs
{
    public class GraphListDirected : GraphList
    {
        public GraphListDirected() : base() { }

        public override void AddEdge(int start, int end)
        {
            edgeList[start].AddLast(end);
        }
    }
}
