﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Project.Models
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
    }
}
