using Project.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Project.FIleHandling
{
    public static class JsonModelSerializer
    {
        public static async Task SerializeModel(SirModel sirModel, string fileName)
        {
            string jsonFileName = Constants.DataFolderPath + fileName;

            // we want a pretty print
            var options = new JsonSerializerOptions();
            options.WriteIndented = true;

            using FileStream createStream = File.Create(jsonFileName);
            await JsonSerializer.SerializeAsync(createStream, sirModel, options: options);
        }
    }
}
