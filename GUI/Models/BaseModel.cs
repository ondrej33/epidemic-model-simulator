using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;

namespace GUI.Models
{
    public abstract class BaseModel
    {
        // type of the model (SIR, SIRS...)
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ModelType Type { get; set; }

        // id of the model, distinguishes between models of the same type
        public int ID { get; set; }

        // Attributes common for all models
        public int PopulationSize { get; set; }
        public int TimeInfection { get; set; }
        public double R0 { get; set; }

        // Attributes common for both SIR and SIRS models
        public int SusceptibleInit { get; set; }
        public int InfectedInit { get; set; }
        public int RemovedInit { get; set; }

        // dictionary describing events, tuple of : parameter to change, in what time, to which value 
        [JsonIgnore]
        public List<(ParameterType param, double time, double newVal)> Events { get; set; }

        // this will tell us how long simulation will be
        public int TimeToSimulate { get; set; }

        public BaseModel()
            => Events = new List<(ParameterType param, double time, double newVal)>();

    }
}
