using System;
using Project.FileHandling;
using Project.Models;
using Project.Plotting;
using Project.Simulators;
using System.Text.Json;
using System.IO;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var sirModel = await ModelLoader.LoadJson("file.json");

            var simulator = new SirSimulator();
            simulator.Model = sirModel;
            var time = 300;
            var resultCurves = await simulator.SimulateAsync(time, 0.1);
            var curveLabels = new string[] { "S", "I", "R" };

            var plotCreator = new PlotCreator(800, 400);
            for(int i = 1; i < resultCurves.Count; i++)
            {
                plotCreator.AddCurve(resultCurves[0], resultCurves[i], curveLabels[i - 1]);
            }
            plotCreator.CreatePicture(Constants.DataFolderPath + "picture.png", 
                                      sirModel.Type.ToString() + sirModel.ID.ToString());
        }
    }
}
