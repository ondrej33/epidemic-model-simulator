using System.Runtime.Serialization;

namespace Project.Models
{
    public enum ModelType
    {
        [EnumMember(Value = "SIR")]
        SIR,
        [EnumMember(Value = "SIRS")]
        SIRS
    }
}
