using Project.FileHandling;
using Project.Plotting;
using Project.Exceptions;
using Project.Models;
using Project.Simulators;
using System;
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

            await IterateThroughModelsAsync(paths);
        }

        public static async Task IterateThroughModelsAsync(List<string> modelPaths)
        {
            // we will iterate through all models
            int id = 0;
            foreach (var path in modelPaths)
            {
                // first we load the model
                BaseModel model;
                try
                {
                    // TODO - more data types
                    model = await ModelLoader.LoadModel(path);
                    model.ID = id;
                    id++;
                }
                catch (BadModelFormatException e)
                {
                    UserInterface.WriteError(e.Message);
                    return;
                }

                // then we create a corresponding simulator
                var simulator = new Simulator();
                simulator.Model = model;

                // we do the computations
                var resultCurves = await simulator.SimulateAsync(model.TimeToSimulate, 0.1);

                // and we create the graphs
                var curveLabels = new string[] { "S", "I", "R" };
                var plotCreator = new PlotCreator(800, 400);
                for (int i = 1; i < resultCurves.Count; i++)
                {
                    plotCreator.AddCurve(resultCurves[0], resultCurves[i], curveLabels[i - 1]);
                }

                // TODO - async
                plotCreator.CreatePicture(Constants.DataFolderPath + $"picture{model.ID}.png",
                                          model.Type.ToString() + $" id={model.ID}");
            }
        }
    }
}
