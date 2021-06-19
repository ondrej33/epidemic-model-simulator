
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace GUI.Plotting
{
    /* Creates the file for picture and some basics of graph like axes.
     * Also has static versions of methods to work with given plot. */
    public static class PlotCreator
    {
        private static Color[] Colors1 = { Color.Green, Color.Red, Color.Blue };
        private static Color[] Colors2 = { Color.SpringGreen, Color.Orange, Color.Aqua };

        private static string[] Labels1 = { "S", "I", "R" };
        private static string[] Labels2 = { "S_new", "I_new", "R_new" };

        public static void AddCurve(ScottPlot.Plot pl, double[] xPoints, 
            double[] yPoints, string curveLabel, Color col)
        {
            pl.AddScatter(xPoints, yPoints, label: curveLabel, color: col,
                          lineWidth: 2, markerSize: 0);
        }

        // param resultCurves contains x coords in 0th elem and then y coords for each curve
        // have 2 color/label modes, depends on argument defaultThings
        public static void PrepareGraphSIR(ScottPlot.Plot pl, List<double[]> resultCurves,
                                           bool defaultThings = true)
        {
            var curveLabels = defaultThings ? Labels1 : Labels2;
            var colors = defaultThings ? Colors1 : Colors2;
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
