
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace GUI.Plotting
{
    /* Creates the file for picture and some basics of graph like axes.
     * Also has static versions of methods to work with given plot. */
    public static class PlotCreator
    {
        public static void AddCurve(ScottPlot.Plot pl, double[] xPoints, 
            double[] yPoints, string curveLabel, Color col)
        {
            pl.AddScatter(xPoints, yPoints, label: curveLabel, color: col,
                          lineWidth: 2, markerSize: 0);
        }

        // param resultCurves contains x coords in 0th elem and then y coords for each curve
        public static void PrepareGraphSIR(ScottPlot.Plot pl, List<double[]> resultCurves)
        {
            var curveLabels = new string[] { "S", "I", "R" };
            Color[] colors = { Color.Green, Color.Red, Color.Blue };
            for (int i = 1; i < resultCurves.Count; i++)
            {
                AddCurve(pl, resultCurves[0], resultCurves[i], curveLabels[i - 1], colors[i - 1]);
            }
        }

        // Labels graph + saves it into the picture
        public static async Task CreatePictureAsync(ScottPlot.Plot pl, string filePath, string title)
        {
            LabelGraph(pl, title);
            await Task.Run(() => { pl.SaveFig(filePath); });
        }

        // Labels the graph given
        public static void LabelGraph(ScottPlot.Plot pl, string title)
        {
            pl.Legend();
            pl.Title(title);
            pl.YLabel("Number of people");
            pl.XLabel("Days");
        }
    }
}
