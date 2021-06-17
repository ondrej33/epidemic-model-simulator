using System.Collections.Generic;
using System.Threading.Tasks;

namespace GUI.Simulators
{
    public interface ISimulator
    {
        public List<double[]> Simulate(int time_period, double scale);

        public Task<List<double[]>> SimulateAsync(int time_period, double scale);
    }
}
