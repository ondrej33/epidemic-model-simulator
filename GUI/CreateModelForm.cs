using GUI.Models;
using GUI.Plotting;
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
    public partial class CreateModelForm : Form
    {
        private BaseModel model;

        public CreateModelForm()
        {
            InitializeComponent();
            TimmuTB.Text = "-1";
        }

        private bool CanBeParsedInt(out int num, string str, string paramName)
        {
            bool succ = int.TryParse(str, out num);
            if (!succ)
            {
                string message = $"Value \"{paramName}\" can not be parsed to integer.";
                string caption = "Error";
                MessageBox.Show(message, caption);
            }
            return succ;
        }

        private bool CanBeParsedDouble(out double num, string str, string paramName)
        {
            str = str.Replace('.', ',');
            bool succ = double.TryParse(str, out num);
            if (!succ)
            {
                string message = $"String \"{paramName}\" can not be parsed to double.";
                string caption = "Error";
                MessageBox.Show(message, caption);
            }
            return succ;
        }

        private bool CanBeParsedParamType(out ParameterType param, string str)
        {
            bool succ = Enum.TryParse(str, out param);
            if (!succ)
            {
                succ = false;
                string message = $"Your given string for \"Parameter\" is not supported.";
                string caption = "Error";
                MessageBox.Show(message, caption);
            }
            return succ;
        }

        private bool ParseInput(out BaseModel model)
        {
            model = new SirModel(); // just a placeholder, so that we can return early

            // check all params are provided (TimmuTB is -1 as default)
            if (PopTB.Text == "" || R0TB.Text == "" || TimeTB.Text == "" ||
                STB.Text == "" || ITB.Text == "" || RTB.Text == "" || TinfTB.Text == "")
            {
                string message = "Some value was not provided.";
                string caption = "Error";
                MessageBox.Show(message, caption);
                return false;
            }

            // lets distinguish between SIR and SIRS - if TimmuTB is -1, it will be SIRS
            int timeImmunity;
            if (CanBeParsedInt(out timeImmunity, TimmuTB.Text, "Immunity time"))
            {
                if (timeImmunity == -1)
                {
                    model = new SirModel();
                }
                else if (timeImmunity == 0)
                {
                    string message = "Immunity time can not be 0.";
                    string caption = "Error";
                    MessageBox.Show(message, caption);
                    return false;
                }
                else
                {
                    model = new SirsModel();
                    (model as SirsModel).TimeImmune = timeImmunity;
                }
            }

            // check all can be parsed and numbers are acceptable
            double r0;
            int pop, timeInf, time, s, i, r;

            if (!CanBeParsedDouble(out r0, R0TB.Text.Replace('.', ','), "R0") ||
                !CanBeParsedInt(out pop, PopTB.Text, "Population") ||
                !CanBeParsedInt(out timeInf, TinfTB.Text, "Infection time") ||
                !CanBeParsedInt(out time, TimeTB.Text, "Time period") ||
                !CanBeParsedInt(out s, STB.Text, "S") ||
                !CanBeParsedInt(out i, ITB.Text, "I") ||
                !CanBeParsedInt(out r, RTB.Text, "R"))
            {
                return false; // error message handled separately in the function
            }

            if (s + i + r != pop)
            {
                string message = "Inconsistency in numbers (S+I+R != Population size).";
                string caption = "Error";
                MessageBox.Show(message, caption);
                return false;
            }

            if (timeInf == 0 || time == 0 || pop == 0)
            {
                string message = "Any of {TimeInf, Time, Population} must not be 0.";
                string caption = "Error";
                MessageBox.Show(message, caption);
                return false;
            }

            model.PopulationSize = pop;
            model.R0 = r0;
            model.TimeToSimulate = time;
            model.TimeInfection = timeInf;
            model.SusceptibleInit = s;
            model.InfectedInit = i;
            model.RemovedInit = r;

            // lets now save events (they are validated during creation)
            foreach (var eventItem in EventsList.Items)
            {
                ListViewItem item = (ListViewItem)eventItem;
                ParameterType param = Enum.Parse<ParameterType>(item.Text);

                // check that no Timmu is in events if we have SIRS
                if (model.Type == ModelType.SIR && param == ParameterType.Timmu)
                {
                    string message = "There cant be event with Timmu for SIR model.";
                    string caption = "Error";
                    MessageBox.Show(message, caption);
                    return false;
                }
                var newVal = double.Parse(item.SubItems[1].Text.Replace('.', ','));
                var eventTime = int.Parse(item.SubItems[2].Text);

                model.Events.Add((param, eventTime, newVal));
            }
            return true;
        }

        private async void SimulateNewBtn_Click(object sender, EventArgs e)
        {
            AddToSameBtn.Enabled = false;
            SimulateNewBtn.Enabled = false;

            BaseModel model;
            if (!ParseInput(out model)) { return; }

            // simulate
            var simulator = new Simulator(model);
            var resultCurves = await simulator.SimulateAsync(model.TimeToSimulate, 0.1);

            // clear the current graph and show the new
            PlotWindow.Plot.Clear();
            PlotCreator.PrepareGraphSIR(PlotWindow.Plot, resultCurves);
            PlotCreator.LabelGraph(PlotWindow.Plot, "New Graph");

            // enable button for adding another graph to this one
            AddToSameBtn.Enabled = true;
            SimulateNewBtn.Enabled = true;
        }

        private async void AddToSameBtn_Click(object sender, EventArgs e)
        {
            AddToSameBtn.Enabled = false;
            BaseModel model;
            if (!ParseInput(out model)) { return; }

            // simulate
            var simulator = new Simulator(model);
            var resultCurves = await simulator.SimulateAsync(model.TimeToSimulate, 0.1);

            // append the new curves to the same graph, with different colors/labels
            PlotCreator.PrepareGraphSIR(PlotWindow.Plot, resultCurves, defaultThings: false);
            PlotCreator.LabelGraph(PlotWindow.Plot, "Combined Graph");
        }

        private void AddEventBtn_Click(object sender, EventArgs e)
        {
            // check that values are provided
            if (EventParamTB.Text == "" || EventValueTB.Text == "" || EventTimeTB.Text == "")
            {
                string message = "Some value was not provided.";
                string caption = "Error";
                MessageBox.Show(message, caption);
                return;
            }

            // check if it can be parsed
            ParameterType param;
            double value;
            double time;

            if (!CanBeParsedParamType(out param, EventParamTB.Text) ||
                !CanBeParsedDouble(out value, EventValueTB.Text, "New value") ||
                !CanBeParsedDouble(out time, EventTimeTB.Text, "Time"))
            {
                return; // error message handled separately in the function
            }

            // save results into the list
            ListViewItem item = new ListViewItem(EventParamTB.Text);
            item.SubItems.Add(EventValueTB.Text);
            item.SubItems.Add(EventTimeTB.Text);
            EventsList.Items.Add(item);

            // and now clear the text boxes
            EventParamTB.Text = "";
            EventValueTB.Text = "";
            EventTimeTB.Text = "";
        }

        private void RemoveEventBtn_Click(object sender, EventArgs e)
        {
            // TODO
        }
    }
}
