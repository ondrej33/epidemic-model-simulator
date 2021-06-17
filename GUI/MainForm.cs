using GUI.FileHandling;
using GUI.Models;
using GUI.Plotting;
using GUI.Exceptions;
using GUI.Simulators;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public async Task MainProgram(string inputPath)
        {
            List<string> modelPaths;
            modelPaths = InputListParser.GetFilePaths(inputPath);
            // TODO - print a number of paths received
               
            if (modelPaths.Count() == 0)
            {
                // TODO if we got no model, error message
            }

            // we will iterate through all models
            int id = 0;
            int counter = 0;
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
                // TODO - check if other exception arent possible 
                catch (BadModelFormatException e)
                {
                    // TODO - inform user something happened
                    counter++;
                    continue;
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

                counter++;
                ProgressBar.Invoke(new Action(() =>
                {
                    ProgressBar.Value = (int)((float)counter / modelPaths.Count() * 100);
                }));
            }
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            try
            {
                ProgressBar.Invoke(new Action(() =>
                {
                    ProgressBar.Value = 0;
                }));
                await MainProgram(FileBrowser.Path);
            }
            catch (Exception exc)
            {
                // TODO - HANDLE EXCEPTIONS
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // TODO - switch from file mode to interactive mode
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO - switch to model creating form
        }
    }
}
