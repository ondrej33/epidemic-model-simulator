using GUI.Models;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;

namespace GUI.FileHandling
{
    public static class JsonSerialization
    {
        public static async Task SerializeModel(BaseModel model, string fileName)
        {
            // TODO make this possible for SIRS too
            string jsonFileName = Constants.DataFolderPath + fileName;

            // we want a pretty print
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;

            using FileStream createStream = File.Create(jsonFileName);
            await JsonSerializer.SerializeAsync(createStream, model, options: options);
        }

        public static async Task<BaseModel> DeserializeModel(string fileName)
        {
            // TODO make this possible for SIRS too
            string jsonFileName = Constants.DataFolderPath + fileName;
            using FileStream openStream = File.OpenRead(jsonFileName);

            var model = await JsonSerializer.DeserializeAsync<BaseModel>(openStream);
            return model;
        }
    }
}
