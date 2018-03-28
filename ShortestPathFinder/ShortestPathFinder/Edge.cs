namespace ShortestPathFinder
{
    public class Edge
    {
        public Node From;
        public Node To;
        public int Cost;

        public Edge(Node from, Node to, int cost)
        {
            From = from;
            To = to;
            Cost = cost;
        }
    }
}