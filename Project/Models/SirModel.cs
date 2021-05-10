using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class SirModel : BaseModel
    {
        public int SusceptibleInit { get; set; }
        public int InfectedInit { get; set; }
        public int RemovedInit { get; set; }

        public SirModel(int id_num) 
        {
            type = ModelType.SIR;
            id = id_num;
        }
    }
}
