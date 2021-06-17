
namespace GUI.Plotting
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
            plot.AddScatter(xPoints, yPoints, label: curveLabel, lineWidth: 2, markerSize: 0);
        }

        public void CreatePicture(string filePath, string title)
        {
            plot.Legend();
            plot.Title(title);
            plot.YLabel("Number of people");
            plot.XLabel("Days");
            plot.SaveFig(filePath);
        }

    }
}
