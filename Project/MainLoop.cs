using Project.FileHandling;
using Project.Models;
using Project.Simulators;
using System.Collections.Generic;
using System.Threading.Tasks;
using Project.Plotting;
using Project.Exceptions;

namespace Project
{
    public class MainLoop
    {
        private List<string> modelPaths;

        public MainLoop(List<string> paths)
            => modelPaths = paths;

        public async Task IterateThroughModelsAsync()
        {
            // we will iterate through all models
            foreach(var path in modelPaths)
            {
                // first we load the model
                SirModel model;
                try
                {
                    model = await ModelLoader.LoadModel(path, FormatType.JSON);
                }
                catch (BadModelFormatException e)
                {
                    UserInterface.WriteError(e.Message);
                    return;
                }

                // then we create a corresponding simulator
                var simulator = new SirSimulator();
                simulator.Model = model;

                // we do the computations
                var time = 300;
                var resultCurves = await simulator.SimulateAsync(time, 0.1);

                // and we create the graphs
                var curveLabels = new string[] { "S", "I", "R" };
                var plotCreator = new PlotCreator(800, 400);
                for (int i = 1; i < resultCurves.Count; i++)
                {
                    plotCreator.AddCurve(resultCurves[0], resultCurves[i], curveLabels[i - 1]);
                }
                plotCreator.CreatePicture(Constants.DataFolderPath + "picture.png",
                                          model.Type.ToString() + model.ID.ToString());
            }
        }
    }
}
