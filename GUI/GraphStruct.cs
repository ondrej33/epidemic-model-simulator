using GUI.Models;
using System.Collections.Generic;

namespace GUI
{
    public class GraphStruct
    {
        public List<double[]> Coords { get; private set; }
        public string Title { get; private set; }

        // model to store and access the parameters
        public BaseModel Model { get; set; }


        public GraphStruct(List<double[]> coords, string title, BaseModel model)
        {
            Coords = coords;
            Title = title;
            Model = model;
        }

        public GraphStruct()
            => Coords = new List<double[]>();
    }
}
