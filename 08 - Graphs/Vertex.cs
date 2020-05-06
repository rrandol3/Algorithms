using System;
using System.Collections.Generic;
using System.Text;

namespace _08___Graphs
{
    public class Vertex
    {
        public char Label { get; set; }
        public bool WasVisited { get; set; }
        public Vertex(char label)
        {
            Label = label;
            WasVisited = false;
        }
    }
}
