using System;
using Project.FileHandling;
using Project.Models;
using Project.Plotting;
using Project.Simulators;
using Project.Exceptions;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        static async Task Main()
        {
            string inputPath = UserInterface.GetInputPath();
            List<string> paths;
            try 
            {
                paths = InputListParser.GetFilePaths(inputPath);
                UserInterface.InformAboutNumberPaths(paths.Count);
            }
            catch (BadPathException e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            var analyzer = new MainLoop(paths);
            await analyzer.IterateThroughModelsAsync();
        }
    }
}
