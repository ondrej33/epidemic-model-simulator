using System;
using Project.InputHandling;
using Project.Models;
using Project.Plotting;
using Project.Simulators;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var sirModel = new SirModel(1);
            sirModel.SusceptibleInit = 9999999;
            sirModel.InfectedInit = 1;
            sirModel.RemovedInit = 0;
            sirModel.R0 = 3;
            sirModel.PopulationSize = 10000000;
            sirModel.TimeInfection = 14;
            int time = 300;

            var simulator = new SirSimulator();
            simulator.Model = sirModel;
            var resultCurves = simulator.Simulate(time, 0.1);
            var curveLabels = new string[] { "S", "I", "R" };

            var plotCreator = new PlotCreator(800, 400);
            for(int i = 1; i < resultCurves.Count; i++)
            {
                plotCreator.AddCurve(resultCurves[0], resultCurves[i], curveLabels[i - 1]);
            }
            plotCreator.CreatePicture(Constants.DataFolderPath + "picture.png");
        }
    }
}
