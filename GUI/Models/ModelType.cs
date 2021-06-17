using System.Runtime.Serialization;

namespace GUI.Models
{
    public enum ModelType
    {
        [EnumMember(Value = "SIR")]
        SIR,
        [EnumMember(Value = "SIRS")]
        SIRS
    }
}
