using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    public enum ModelType
    {
        [EnumMember(Value = "SIR")]
        SIR,
        [EnumMember(Value = "SIRS")]
        SIRS,
        [EnumMember(Value = "SEIR")]
        SEIR
    }
}
