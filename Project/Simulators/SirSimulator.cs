using System.Collections.Generic;
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
            int eventIndex = 0; // index of a next event to check

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
                // first we will check if some events should happen
                // events are sorted by time, so we need to check just first few (in case more have the same time)
                while (eventIndex < Model.Events.Count && Model.Events[eventIndex].time <= xVal[t - 1] + scale)
                {
                    switch (Model.Events[eventIndex].param)
                    {
                        case ParameterType.R0:
                            Model.R0 = Model.Events[eventIndex].newVal;
                            infectConst = Model.R0 / Model.TimeInfection;
                            break;
                        case ParameterType.Tinf:
                            Model.TimeInfection = (int) Model.Events[eventIndex].newVal;
                            infectConst = Model.R0 / Model.TimeInfection;
                            break;
                        default:
                            break;
                    }
                    eventIndex++;
                }

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

        /* Async wrapper for above method */
        public async Task<List<double[]>> SimulateAsync(int time_period, double scale)
        {
            var resultList = await Task.Run(() => Simulate(time_period, scale));
            return resultList;
        }

    }
}
