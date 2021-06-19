
namespace GUI.Models
{
    /* Most elemental model type, immunity holds forever */
    public class SirModel : BaseModel
    {
        public SirModel()
            => Type = ModelType.SIR;

        public SirModel(int id_num) 
        {
            Type = ModelType.SIR;
            ID = id_num;
        }
    }
}
