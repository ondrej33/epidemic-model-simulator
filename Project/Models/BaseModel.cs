using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public abstract class BaseModel
    {
        // type of the model (SIR, SIRS...)
        protected ModelType type;

        // id of the model, distinguishes between models of the same type
        protected int id;

        // Attributes common for all models
        public int PopulationSize { get; set; }
        public int TimeInfection { get; set; }
        public double R0 { get; set; }
    }
}
