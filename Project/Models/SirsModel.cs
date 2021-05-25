
namespace Project.Models
{
    public class SirsModel : SirModel
    {
        public int TimeRecovery { get; set; }

        public SirsModel()
            => Type = ModelType.SIRS;

        public SirsModel(int id) : base(id) 
            => Type = ModelType.SIRS;
    }
}
