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
        public PlotForm()
        {
            InitializeComponent();
        }

        private void Plot_Load(object sender, EventArgs e)
        {
            // PlotWindow.Plot.AddScatter()
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            // TODO - switch graphs
        }

        private void PlotForm_Load(object sender, EventArgs e)
        {
            // TODO - load graphs
        }
    }
}
