using System;
using System.Collections;
using System.Collections.Generic;
using ShortestPathFinder.interaction;
using System.Linq;


namespace ShortestPathFinder
{
    internal static class Program
    {
        public static void Main()
        {
            Cleaner.Clean();
            var result = PathFinder.Find(Parser.Parse(Reader.Read()));
            var totalPrice = result.Item1;
            var path = result.Item2;
            var startNode = result.Item3;
            var finishNode = result.Item4;
            if (totalPrice == int.MaxValue)
            {
                Writer.Write("N");
                return;
            }

            var finishResult = new List<int>();
            Writer.Write("Y");
            for (var i = finishNode; i > 0; i = path[i])
            {
                finishResult.Add(i);
            }
            finishResult.Reverse();
            var str = finishResult.Aggregate("", (current, integer) => current + (integer + " "));
            Writer.Write(str);
            Writer.Write(totalPrice.ToString());
        }
    }
}