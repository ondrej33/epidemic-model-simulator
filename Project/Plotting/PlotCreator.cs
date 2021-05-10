using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Plotting
{
    /* Creates the file for picture and some basics of graph like axes.. */
    public class PlotCreator
    {
        private ScottPlot.Plot plot;
        public PlotCreator(int width, int height)
        {
            plot = new ScottPlot.Plot(width, height);
        }

        public void AddCurve(double[] xPoints, double[] yPoints, string curveLabel)
        {
            plot.PlotScatter(xPoints, yPoints, label: curveLabel, lineWidth: 2, markerSize: 0);
        }

        public void CreatePicture(string filePath)
        {
            plot.Legend();
            plot.SaveFig(filePath);
        }

    }
}
