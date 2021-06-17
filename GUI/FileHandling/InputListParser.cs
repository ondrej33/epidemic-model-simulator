using System.Collections.Generic;
using System.IO;
using System.Linq;
using GUI.Exceptions;

namespace GUI.FileHandling
{
    /* Input to the program is a file containing paths to all of the models
     * This class will be used to check it and parse those paths to a list */
    public static class InputListParser
    {
        /* Parses lines and checks if they consist of valid file paths
         * If not, throws an exception */
        public static List<string> GetFilePaths(string inputPath)
        {
            List<string> filePaths = File.ReadLines(inputPath).ToList();
            foreach(var path in filePaths)
            {
                if (!File.Exists(path))
                {
                    throw new BadPathException(path);
                }
            }
            return filePaths;
        }
    }
}
