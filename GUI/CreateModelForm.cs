using GUI.Models;
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

        private void SimulateButton_Click(object sender, EventArgs e)
        {
            // check all params are provided (TimmuTB is -1 as default)
            if (PopTB.Text == "" || R0TB.Text == "" || TimeTB.Text == "" ||
                STB.Text == "" || ITB.Text == "" || RTB.Text == "" || TinfTB.Text == "")
            {
                string message = "Some value was not provided.";
                string caption = "Error";
                MessageBox.Show(message, caption);
                return;
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
                    return;
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

            if (!CanBeParsedDouble(out r0, R0TB.Text.Replace('.',','), "R0") ||
                !CanBeParsedInt(out pop, PopTB.Text, "Population") ||
                !CanBeParsedInt(out timeInf, TinfTB.Text, "Infection time") ||
                !CanBeParsedInt(out time, TimeTB.Text, "Time period") ||
                !CanBeParsedInt(out s, STB.Text, "S") ||
                !CanBeParsedInt(out i, ITB.Text, "I") ||
                !CanBeParsedInt(out r, RTB.Text, "R"))
            {
                return; // error message handled separately in the function
            }

            if (s + i + r != pop)
            {
                string message = "Inconsistency in numbers (S+I+R != Population size).";
                string caption = "Error";
                MessageBox.Show(message, caption);
                return;
            }

            if (timeInf == 0 || time == 0 || pop == 0)
            {
                string message = "Any of {TimeInf, Time, Population} must not be 0.";
                string caption = "Error";
                MessageBox.Show(message, caption);
                return;
            }

            model.PopulationSize = pop;
            model.R0 = r0;
            model.TimeToSimulate = time;
            model.TimeInfection = timeInf;
            model.SusceptibleInit = s;
            model.InfectedInit = i;
            model.RemovedInit = r;

            // lets now save events (they are validated during creation)

            // check that no Timmu in events if we dont have SIRS

            // simulate it

            // show the graph
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

            // check it can be parsed TODO
            ParameterType param;
            double value;
            double time;

            // TODO - maybe delete those out params??
            if (!CanBeParsedParamType(out param, EventParamTB.Text) ||
                !CanBeParsedDouble(out value, EventValueTB.Text, "New value") ||
                !CanBeParsedDouble(out time, EventTimeTB.Text, "Time"))
            {
                return; // error message handled separately in the function
            }

            ListViewItem item = new ListViewItem(EventParamTB.Text);
            item.SubItems.Add(EventValueTB.Text);
            item.SubItems.Add(EventTimeTB.Text);
            EventsList.Items.Add(item);
        }
    }
}
