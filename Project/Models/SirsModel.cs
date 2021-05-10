using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public class SirsModel : SirModel
    {
        public int TimeRecovery { get; set; }

        public SirsModel(int id) : base(id) 
        {
            type = ModelType.SIRS;
        }
    }
}
