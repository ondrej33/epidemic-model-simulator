using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Simulators
{
    public interface ISimulator
    {
        public List<double[]> Simulate(int time_period, double scale);
    }
}
