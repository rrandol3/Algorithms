using System;
using System.Collections.Generic;
using System.Text;

namespace _08___Graphs
{
    public class Notes
    {
        public static void Main(string[] args)
        {
            //Graph Representation
            //Adjacency Matrix - connections are represented by 1 in the row/column index
            int[,] matrix = new int[3, 3];//can booleans instead of 1's and 0's
            matrix[0, 1] = 1;//says that node 0 is connected to node 1
            //[0 1 0]
            //[0 0 0]
            //[0 0 1]
            
            //Adjacency List - node is represented by array or list index, and list contains connections
            List<int>[] adjList1 = new List<int>[3];//3 nodes, with a list to all there connections
            //or
            List<List<int>> adjList2 = new List<List<int>>();//list of lists
            //or
            List<LinkedList<int>> adjList3 = new List<LinkedList<int>>();//list of linkedlists
            //Have to initialize list of each array first
            for (int i = 0; i < adjList1.Length; i++)
            {
                adjList1[i] = new List<int>();
            }
            adjList1[0].Add(1);//adds a connections from 0 node to 1 node

            //Edge List - represents a array/list of pairs
            int[][] edgeList = new int[3][];//3 represents 3 edges in graph
            //or
            List<List<int>> edgeList1 = new List<List<int>>();//can also represent a edge list
            //have to inilialize array in each array
            for (int i = 0; i < edgeList.Length; i++)
            {
                edgeList[i] = new int[2];//since each array of arrays contains a src and dest node
            }
            edgeList[0][0] = 0;//first item of pair
            edgeList[0][1] = 1;//second item of pair
            //above pair represents a connection from node 0 to node 1
        }
    }
}
