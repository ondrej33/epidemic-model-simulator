using System.Collections.Generic;
using System.Threading.Tasks;

namespace GUI.Simulators
{
    /* This is an interface for all possible simulators
     * I included this in the project, because I plan to create more types
     * of simulators in the future, they all will implement this. */
    public interface ISimulator
    {
        public List<double[]> Simulate(int time_period, double scale);

        public Task<List<double[]>> SimulateAsync(int time_period, double scale);
    }
}
