using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;

namespace ShortestPathFinder.interaction
{
    public class Parser
    {
        public static Tuple<List<Edge>, int, int, int> Parse(List<string> list)
        {
            List<Edge> graph = new List<Edge>();
            var nodesCount = int.Parse(list.First());
            list.RemoveAt(0);
            var fromNode = 0;
            var toNode = 0;
            var hostNode = 1;
            for (var index = 0; index < list.Count; index++)
            {
                var str = list[index];
                if (str == null) continue;
                var intSet = str.Split(' ')
                    .Select(int.Parse)
                    .ToList();
                if (index == list.Count - 2) fromNode = intSet.First();
                else if (index == list.Count - 1) toNode = intSet.First();
                else
                {
                    for (var k = 0; k < intSet.Count; k++)
                    {
                        if (k % 2 == 1) graph.Add(new Edge(new Node(hostNode), new Node(intSet[k-1]), intSet[k]));
                    }
                }
                hostNode++;
            }
            return new Tuple<List<Edge>, int, int, int>(graph, fromNode, toNode, nodesCount);
        }
    }
}