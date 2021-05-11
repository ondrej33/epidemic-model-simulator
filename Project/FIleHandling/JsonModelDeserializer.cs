using Project.Models;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace Project.FileHandling
{
    public static class JsonModelDeserializer
    {
        public static async Task<SirModel> DeserializeModel(string fileName)
        {
            string jsonFileName = Constants.DataFolderPath + fileName;
            using FileStream openStream = File.OpenRead(jsonFileName);

            var sirModel = await JsonSerializer.DeserializeAsync<SirModel>(openStream);
            return sirModel;
        }
    }
}
