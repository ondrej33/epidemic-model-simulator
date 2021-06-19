using GUI.Exceptions;
using GUI.FileHandling;
using GUI.Models;
using GUI.Simulators;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace GUI
{
    public partial class MainForm : Form
    {
        public List<GraphStruct> ListGraphs { get; private set; }

        public MainForm()
        {
            InitializeComponent();
            ListGraphs = new List<GraphStruct>();
        }

        /* Displays the MessageBox with error */
        private void DisplayErrorMessage(string message)
        {
            string caption = "Error";
            MessageBox.Show(message, caption);
        }

        private async void StartButton_Click(object sender, EventArgs e)
        {
            // first lets set all things to defaults (so that they restart each time we click this btn)
            ErrorProviderFormat.Clear();
            ProgressBar.Value = 0;
            StartButton.Enabled = false;
            InteractiveResultsBtn.Enabled = false;
            ListGraphs.Clear();

            if (!File.Exists(InputFileBrowser.Path))
            {
                DisplayErrorMessage("Input path is invalid.");
                StartButton.Enabled = true;
                return;
            }
            if (!Directory.Exists(OutputDirBrowser.DirPath))
            {
                DisplayErrorMessage("Output path is invalid.");
                StartButton.Enabled = true;
                return;
            }

            List<string> modelPaths;
            try
            {
                modelPaths = InputListParser.GetFilePaths(InputFileBrowser.Path);
                // TODO - print a number of paths received
            }
            catch (BadPathException exc)
            {
                // Display the MessageBox with error
                DisplayErrorMessage($"The path in input file is invalid: {exc.Message}");
                StartButton.Enabled = true;
                return;
            }

            if (modelPaths.Count() == 0)
            {
                string message = "No valid path was found in the input file.";
                MessageBox.Show(message, caption: "Message");
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
                    model = await ModelLoader.LoadModel(path);
                    model.ID = id;
                    id++;
                }
                // TODO - check if other exceptions arent possible 
                catch (BadModelFormatException exc)
                {
                    ErrorProviderFormat.SetError(InputFileBrowser, exc.Message); // just minor error
                    counter++;
                    continue;
                }

                // then we do the simulations (computations)
                var simulator = new Simulator(model);
                var resultCurves = await simulator.SimulateAsync(model.TimeToSimulate, 0.1);

                // and we create the graphs
                ScottPlot.Plot plot = new ScottPlot.Plot(1080, 720);
                PlotCreator.PrepareGraphSIR(plot, resultCurves);

                string graphTitle = model.Type.ToString() + $" (id={model.ID})";
                string graphFileName = OutputDirBrowser.DirPath + $"picture{model.ID}_{model.Type}.png";
                await PlotCreator.CreatePictureAsync(plot, graphFileName, graphTitle);

                // and update the progress
                ListGraphs.Add(new GraphStruct(resultCurves, graphTitle, model));
                counter++;
                ProgressBar.Value = (int)((float)counter / modelPaths.Count() * 100);
            }

            // after the procedure is finished, lets enable button again
            StartButton.Enabled = true;
            if (ListGraphs.Count() > 0) // new we can also enable in-app results view
            {
                InteractiveResultsBtn.Enabled = true;
            }
        }

        /* Opens the new creative mode, after closing it app terminates. */
        private void CreativeModeBtn_Click(object sender, EventArgs e)
        {
            var frm = new CreativeForm();
            frm.Location = Location;
            frm.StartPosition = FormStartPosition.Manual;
            frm.FormClosing += delegate { Close(); };
            frm.Show();
            Hide();
        }

        /* Opens the result-check mode, after closing it we get back and can
         * run another simulations. */
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
