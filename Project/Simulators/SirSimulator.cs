using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Models;

namespace Project.Simulators
{
    public class SirSimulator : ISimulator
    {
        public SirModel Model { get; set; }
        
        /* Returns list where first item contains xValues for all points and
         * every other entry contains yValues for each curve. */
        public List<double[]> Simulate(int time_period, double scale = 1.0)
        {
            int valuesCount = (int)(time_period / scale) + 1;

            var S = new double[valuesCount];
            var I = new double[valuesCount];
            var R = new double[valuesCount];
            var xVal = new double[valuesCount];

            S[0] = Model.SusceptibleInit;
            I[0] = Model.InfectedInit;
            R[0] = Model.RemovedInit;
            xVal[0] = 0;

            double infectConst = Model.R0 / Model.TimeInfection;
            

            for (int t = 1; t < valuesCount; t++)
            {
                var dS = -infectConst * (S[t-1] * I[t-1] / Model.PopulationSize);
                var dR = I[t-1] / Model.TimeInfection;
                var dI = -dS - dR;

                S[t] = S[t - 1] + dS * scale;
                I[t] = I[t - 1] + dI * scale;
                R[t] = R[t - 1] + dR * scale;
                xVal[t] = xVal[t - 1] + scale;
            }
            return new List<double[]> { xVal, S, I, R };
        }
    }
}
