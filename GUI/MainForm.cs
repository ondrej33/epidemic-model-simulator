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
using System.IO;

namespace GUI
{
    public partial class MainForm : Form
    {
        public List<(List<double[]> coords, string name)> ListGraphs { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            ListGraphs = new List<(List<double[]> coords, string name)>();
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            // first lets set all things to defaults (so that they restart each time we click this btn)
            ErrorProviderFormat.Clear();
            ProgressBar.Value = 0;
            StartButton.Enabled = false;
            InteractiveResultsBtn.Enabled = false;
            ListGraphs.Clear();

            if (!File.Exists(FileBrowser.Path))
            {
                // Displays the MessageBox with error
                string message = "Input path is invalid.";
                string caption = "Error";
                MessageBox.Show(message, caption);
                StartButton.Enabled = true;
                return;
            }

            List<string> modelPaths;
            modelPaths = InputListParser.GetFilePaths(FileBrowser.Path);
            // TODO - print a number of paths received

            if (modelPaths.Count() == 0)
            {
                ErrorProviderFormat.SetError(FileBrowser, "no path was found in input");
                ProgressBar.Value = 100;
                StartButton.Enabled = true;
                return;
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
                // TODO - check if other exceptions arent possible 
                catch (BadModelFormatException exc)
                {
                    ErrorProviderFormat.SetError(FileBrowser, exc.Message);
                    counter++;
                    continue;
                }

                // then we do the simulations (computations)
                var simulator = new Simulator();
                simulator.Model = model;
                var resultCurves = await simulator.SimulateAsync(model.TimeToSimulate, 0.1);

                // and we create the graphs
                ScottPlot.Plot plot = new ScottPlot.Plot(1080, 720);
                PlotCreator.PrepareGraphSIR(plot, resultCurves);

                string graphTitle = model.Type.ToString() + $" (id={model.ID})";
                string graphFileName = Constants.DataFolderPath + $"picture{model.Type}{model.ID}.png";
                await PlotCreator.CreatePictureAsync(plot, graphFileName, graphTitle);

                // and update the progress
                ListGraphs.Add((resultCurves, graphTitle));
                counter++;
                ProgressBar.Value = (int)((float)counter / modelPaths.Count() * 100);
            }

            // after the procedure is finished, lets enable button again
            StartButton.Enabled = true;
            if (ListGraphs.Count() > 0) // lets also enable special result view, if we have something to show
            {
                InteractiveResultsBtn.Enabled = true;
            }
        }

        private void CreateModelBtn_Click(object sender, EventArgs e)
        {
            var frm = new CreateModelForm();
            frm.Location = Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { Close(); };
            frm.Show();
            Hide();
        }

        private void InteractiveResultsBtn_Click(object sender, EventArgs e)
        {
            var frm = new PlotForm(ListGraphs);
            frm.Location = Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { Show(); };
            frm.Show();
            Hide();
        }
    }
}
