using System;
using System.Collections.Generic;

namespace ShortestPathFinder
{
    public class Node
    {
        public Node(int name)
        {
            NodeNumber = name;
        }

        public Node Parent;

        public readonly int NodeNumber;
        public readonly List<Tuple<Node, int>> IncidentNodes = new List<Tuple<Node, int>>();
    }
}