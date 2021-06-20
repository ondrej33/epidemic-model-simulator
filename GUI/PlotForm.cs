using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Project
{
    public partial class PlotForm : Form
    {
        public List<GraphStruct> ListGraphs { get; set; }

        private int index = 0; // index of the displayed model in the list

        /* Adds some params of the model to the displayed list */
        public void AddParamsToList(BaseModel model)
        {
            ListViewItem itemR0 = new ListViewItem("R0");
            itemR0.SubItems.Add(model.R0.ToString());
            ParamsList.Items.Add(itemR0);

            ListViewItem itemTinf = new ListViewItem("Tinf");
            itemTinf.SubItems.Add(model.TimeInfection.ToString());
            ParamsList.Items.Add(itemTinf);

            if (model.Type == ModelType.SIRS)
            {
                ListViewItem itemTimmu = new ListViewItem("Timmu");
                itemTimmu.SubItems.Add((model as SirsModel).TimeImmune.ToString());
                ParamsList.Items.Add(itemTimmu);
            }
        }

        /* Adds all events from the model to the displayed list */
        public void AddEventsToList(BaseModel model)
        {
            foreach (var e in model.Events)
            {
                ListViewItem item = new ListViewItem(e.param.ToString());
                item.SubItems.Add(e.newVal.ToString());
                item.SubItems.Add(e.time.ToString());
                EventsList.Items.Add(item);
            }
        }

        /* Initializes form, displays first graph in the list */
        public PlotForm(List<GraphStruct> listGraphs)
        {
            InitializeComponent();
            ListGraphs = listGraphs;

            // initially we put the first graph into the plot region
            List<double[]>  firstGraphCoords = listGraphs[0].Coords;
            string firstGraphName = listGraphs[0].Title;
            PlotCreator.PrepareGraphSIR(PlotWindow.Plot, firstGraphCoords);
            PlotCreator.LabelGraph(PlotWindow.Plot, firstGraphName);

            // and put its params and events to the lists
            var model = listGraphs[0].Model;
            AddParamsToList(model);
            AddEventsToList(model);
        }

        /* Loads next graph in the list instead of the current one */
        private void NextButton_Click(object sender, EventArgs e)
        {
            // clear the previous
            PlotWindow.Plot.Clear();
            ParamsList.Items.Clear();
            EventsList.Items.Clear();

            index = (index + 1) % ListGraphs.Count(); // circular queue
            List<double[]> newGraphCoords = ListGraphs[index].Coords;
            string newGraphName = ListGraphs[index].Title;

            // new graphs
            PlotCreator.PrepareGraphSIR(PlotWindow.Plot, newGraphCoords);
            PlotWindow.Plot.Title(newGraphName);

            // new params 
            var model = ListGraphs[index].Model;
            AddParamsToList(model);
            AddEventsToList(model);
        }
    }
}
