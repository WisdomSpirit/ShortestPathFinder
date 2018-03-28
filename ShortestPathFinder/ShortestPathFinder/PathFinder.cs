using System;
using System.Collections.Generic;
using System.Linq;

namespace ShortestPathFinder
{
    public class PathFinder
    {
        public static Tuple<int, int[], int, int> Find(Tuple<List<Edge>, int, int, int> graphTuple)
        {
            var edges = graphTuple.Item1;
            var startNode = graphTuple.Item2;
            var finalNode = graphTuple.Item3;
            var nodeCount = graphTuple.Item4;
            
            var opt = Enumerable.Repeat(int.MaxValue, nodeCount + 1).ToArray();
            var path = Enumerable.Repeat(0, nodeCount + 1).ToArray();
            opt[startNode] = 0;

            for (var pathSize = 1; pathSize <= nodeCount; pathSize++)
            {
                var flag = false;
                foreach (var edge in edges)
                {
                    var previous = opt[edge.To.NodeNumber];
                    if (opt[edge.From.NodeNumber] != int.MaxValue)
                    {
                        opt[edge.To.NodeNumber] =
                            Math.Min(opt[edge.To.NodeNumber], opt[edge.From.NodeNumber] + edge.Cost);
                        path[edge.To.NodeNumber] = edge.From.NodeNumber;
                        flag = true;
                    }

                    if (opt[edge.To.NodeNumber] < previous) edge.To.Parent = edge.From;
                }
                if (!flag) break;
            }
                    
            return new Tuple<int, int[], int, int>(opt[finalNode], path, startNode, finalNode);
            
            
            
            
            
//            var graph = graphTuple.Item1;
//            var startNode = graphTuple.Item2;
//            var finishNode = graphTuple.Item3;
//            var incidentialList = new List<List<int>>();
//            foreach (var node in graph)
//            {
//                incidentialList
//            }            
//            return null;
        }    
    }
}