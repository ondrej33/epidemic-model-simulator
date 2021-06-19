
namespace GUI.Models
{
    /* Similar to SIR, but immunity vanishes over time */
    public class SirsModel : SirModel
    {
        public int TimeImmune { get; set; }

        public SirsModel()
            => Type = ModelType.SIRS;

        public SirsModel(int id) : base(id) 
            => Type = ModelType.SIRS;
    }
}
