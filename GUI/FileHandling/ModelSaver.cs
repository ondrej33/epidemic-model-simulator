using GUI.Models;
using System.Threading.Tasks;

namespace GUI.FileHandling
{
    /* Class that will be used to save (convert) models in different formats 
     * Json is used more or less for testing purposes. */
    public class ModelSaver
    {
        public static Task SaveJson(SirModel model, string fileName)
            // we do not want to switch threads here, that is job of the caller
            => JsonSerialization.SerializeModel(model, fileName);

    }
}
