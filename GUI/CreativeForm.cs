using Project.Models;
using Project.Simulators;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Project
{
    /* This window contains some kind of "Creative mode", where user can
     * create new model with events and display it, or compare models visually */
    public partial class CreativeForm : Form
    {
        public CreativeForm()
        {
            InitializeComponent();
            TimmuTB.Text = "-1"; // default value
        }

        /* Tries to parse integer, saves value into num, shows error message if invalid */
        private bool CanBeParsedInt(out int num, string str, string paramName)
        {
            bool succ = int.TryParse(str, out num);
            if (!succ)
            {
                string message = $"Value \"{paramName}\" can not be parsed to integer.";
                MessageBox.Show(message, caption: "Error");
            }
            return succ;
        }

        /* Tries to parse double, saves value into num, shows error message if invalid */
        private bool CanBeParsedDouble(out double num, string str, string paramName)
        {
            str = str.Replace('.', ','); // so that double parsing is ok with '.'
            bool succ = double.TryParse(str, out num);
            if (!succ)
            {
                string message = $"String \"{paramName}\" can not be parsed to double.";
                MessageBox.Show(message, caption: "Error");
            }
            return succ;
        }

        /* Tries to parse ParameterType, saves value into param, shows error message if invalid */
        private bool CanBeParsedParamType(out ParameterType param, string str)
        {
            bool succ = Enum.TryParse(str, out param);
            if (!succ)
            {
                succ = false;
                string message = $"Your given string for \"Parameter\" is not supported.";
                MessageBox.Show(message, caption: "Error");
            }
            return succ;
        }

        /* Takes inputs from all the text boxes, checks if they are valid
         * If valid, they are saved to model out parameter */
        private bool ParseInput(out BaseModel model)
        {
            model = new SirModel(); // just a placeholder, so that we can return early

            // check all params are provided (TimmuTB is -1 as default)
            if (PopTB.Text == "" || R0TB.Text == "" || TimeTB.Text == "" ||
                STB.Text == "" || ITB.Text == "" || RTB.Text == "" || TinfTB.Text == "")
            {
                string message = "Some value was not provided.";
                MessageBox.Show(message, caption: "Error");
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
                    MessageBox.Show(message, caption: "Error");
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
                MessageBox.Show(message, caption: "Error");
                return false;
            }

            if (timeInf == 0 || time == 0 || pop == 0)
            {
                string message = "Any of {TimeInf, Time, Population} must not be 0.";
                MessageBox.Show(message, caption: "Error");
                return false;
            }

            if (pop < 0 || r0 < 0 || time < 0 || timeInf < 0 || s < 0 || i < 0 || r < 0)
            {
                string message = "None of the values can be negative.";
                MessageBox.Show(message, caption: "Error");
                return false;
            }

            // things look like they are valid, lets save them
            model.PopulationSize = pop;
            model.R0 = r0;
            model.TimeToSimulate = time;
            model.TimeInfection = timeInf;
            model.SusceptibleInit = s;
            model.InfectedInit = i;
            model.RemovedInit = r;

            // lets now save the events (they are validated during creation)
            foreach (var eventItem in EventsList.Items)
            {
                ListViewItem item = (ListViewItem)eventItem;
                ParameterType param = Enum.Parse<ParameterType>(item.Text);

                // check that no Timmu is in events if we have just SIR
                if (model.Type == ModelType.SIR && param == ParameterType.Timmu)
                {
                    string message = "There cant be event with Timmu for SIR model.";
                    MessageBox.Show(message, caption: "Error");
                    return false;
                }
                var newVal = double.Parse(item.SubItems[1].Text.Replace('.', ','));
                var eventTime = int.Parse(item.SubItems[2].Text);

                model.Events.Add((param, eventTime, newVal));
            }
            // at the end we will sort the events by time
            model.Events = model.Events.OrderBy(triplet => triplet.time).ToList();
            return true;
        }

        /* Collects inputs, simulates model and displays it into cleared area */
        private async void SimulateNewBtn_Click(object sender, EventArgs e)
        {
            AddToSameBtn.Enabled = false;
            SimulateNewBtn.Enabled = false;

            BaseModel model;
            if (!ParseInput(out model)) 
            {
                SimulateNewBtn.Enabled = true;
                return; 
            }

            // simulate
            var simulator = new Simulator(model);
            var resultCurves = await simulator.SimulateAsync(model.TimeToSimulate, 0.1);

            // clear the current graph and show the new
            PlotWindow.Plot.Clear();
            PlotCreator.PrepareGraphSIR(PlotWindow.Plot, resultCurves);
            PlotCreator.LabelGraph(PlotWindow.Plot, "New Graph");

            // enable button for adding another graph to this one, reenable current button
            AddToSameBtn.Enabled = true;
            SimulateNewBtn.Enabled = true;
        }

        /* Collects inputs, simulates model and displays it into the same area
         * that the previous model is displayed - can be used for comparing */
        private async void AddToSameBtn_Click(object sender, EventArgs e)
        {
            AddToSameBtn.Enabled = false;
            BaseModel model;
            if (!ParseInput(out model)) 
            {
                AddToSameBtn.Enabled = true;
                return; 
            }

            // simulate
            var simulator = new Simulator(model);
            var resultCurves = await simulator.SimulateAsync(model.TimeToSimulate, 0.1);

            // append the new curves to the same graph, with different colors/labels
            PlotCreator.PrepareGraphSIR(PlotWindow.Plot, resultCurves, defaultSettings: false);
            PlotCreator.LabelGraph(PlotWindow.Plot, "Combined Graph");
        }

        /* Collects 3 event inputs, checks them and adds new event to the list */
        private void AddEventBtn_Click(object sender, EventArgs e)
        {
            // check that values are provided
            if (EventParamTB.Text == "" || EventValueTB.Text == "" || EventTimeTB.Text == "")
            {
                string message = "Some value was not provided.";
                MessageBox.Show(message, caption: "Error");
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

            // save results into the eventList
            ListViewItem item = new ListViewItem(EventParamTB.Text);
            item.SubItems.Add(EventValueTB.Text);
            item.SubItems.Add(EventTimeTB.Text);
            EventsList.Items.Add(item);

            // and lastly clear the text boxes
            EventParamTB.Text = "";
            EventValueTB.Text = "";
            EventTimeTB.Text = "";
        }

        /* Removes all selected items from the eventList */
        private void RemoveEventBtn_Click(object sender, EventArgs e)
        {
            if (EventsList.SelectedItems.Count == 0)
            {
                string message = "None items were selected.";
                MessageBox.Show(message, caption: "Message");

            }

            foreach (var selectedItem in EventsList.SelectedItems)
            {
                EventsList.Items.Remove((ListViewItem) selectedItem);
            }
            EventsList.SelectedItems.Clear();
        }
    }
}
