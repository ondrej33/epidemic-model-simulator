using System.Runtime.Serialization;

namespace Project.Models
{
    /* This enum is here for purposes of distinguishing model types.
     * and also extensibility (more possible model types) */
    public enum ModelType
    {
        [EnumMember(Value = "SIR")]
        SIR,
        [EnumMember(Value = "SIRS")]
        SIRS
    }
}
