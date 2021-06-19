using System.Collections.Generic;

namespace GUI.Models
{
    /* Base class for SIR and SIRS models, and possibly many more */
    public abstract class BaseModel
    {
        public ModelType Type { get; set; } // SIR, SIRS...
        public int ID { get; set; } // id to distinguish between models or so
        public int TimeToSimulate { get; set; } // how long the simulation will be

        // Basic attributes common for all models
        public int PopulationSize { get; set; }
        public int TimeInfection { get; set; }
        public double R0 { get; set; }

        // Attributes common for both SIR/SIRS and other types
        public int SusceptibleInit { get; set; }
        public int InfectedInit { get; set; }
        public int RemovedInit { get; set; }

        // dictionary describing events, tuple of : parameter to change, in what time, to which value 
        public List<(ParameterType param, int time, double newVal)> Events { get; set; }

        public BaseModel()
            => Events = new List<(ParameterType param, int time, double newVal)>();

    }
}
