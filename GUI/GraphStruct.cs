using GUI.Models;
using System.Collections.Generic;

namespace GUI
{
    /* Structure that holds all needed information about created graphs
     * It holds coords for curves, title and model params from which it was created */
    public class GraphStruct
    {
        public List<double[]> Coords { get; private set; }
        public string Title { get; private set; }
        public BaseModel Model { get; set; } // model to store/access the parameters

        public GraphStruct(List<double[]> coords, string title, BaseModel model)
        {
            Coords = coords;
            Title = title;
            Model = model;
        }
    }
}
