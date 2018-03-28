using System.IO;

namespace ShortestPathFinder.interaction
{
    public static class Cleaner
    {
        public static void Clean()
        {
            try
            {    
                File.Delete("out.txt");
            }
            catch (IOException)
            {
            }
        }
    }
}