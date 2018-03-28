using System.Collections.Generic;
using System.IO;

namespace ShortestPathFinder.interaction
{
    public static class Reader
    {
        public static List<string> Read()
        {
            var reader = new StreamReader("in.txt");
            var result = new List<string>();
            while (!reader.EndOfStream)
            {
                result.Add(reader.ReadLine());
            }
            reader.Close();
            return result;
        }
    }
}