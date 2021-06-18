using GUI.Plotting;
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
    public partial class PlotForm : Form
    {
        public List<(List<double[]> coords, string name)> ListGraphs { get; set; }

        private int index = 0;

        public PlotForm(List<(List<double[]> coords, string name)> listGraphs)
        {
            InitializeComponent();
            ListGraphs = listGraphs;

            // we know we have >1 graphs, otherwise we could not get there
            List<double[]>  firstGraphCoords = listGraphs[0].coords;
            string firstGraphName = listGraphs[0].name;
            PlotCreator.PrepareGraphSIR(PlotWindow.Plot, firstGraphCoords);
            PlotCreator.LabelGraph(PlotWindow.Plot, firstGraphName);
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            index = (index + 1) % ListGraphs.Count(); // circular
            List<double[]> newGraphCoords = ListGraphs[index].coords;
            string newGraphName = ListGraphs[index].name;
            PlotWindow.Plot.Clear();

            PlotCreator.PrepareGraphSIR(PlotWindow.Plot, newGraphCoords);
            PlotWindow.Plot.Title(newGraphName);
        }
    }
}
