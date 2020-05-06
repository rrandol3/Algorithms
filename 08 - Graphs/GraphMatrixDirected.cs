using System;
using System.Collections.Generic;
using System.Text;

namespace _08___Graphs
{
    public class GraphMatrixDirected : GraphMatrix
    {
        int[] sortedArray;
        public GraphMatrixDirected() : base() {
            sortedArray = new int[maxVerts];
        }
        public override void AddEdge(int start, int end)
        {
            adjMatrix[start, end] = 1;
        }

        //only works on directed graphs that have no cycles
        public void TopologicalSort()
        {
            int orignalVertCount = nVerts;
            while (nVerts > 0)
            {
                int currentVertex = NoSuccessors();
                if (currentVertex != -1)
                {

                }
            }
        }

        int NoSuccessors()
        {

            return -1;
        }

        void DeleteVertex(int vertex)
        {

        }
    }
}
