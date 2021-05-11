using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.FileHandling
{
    public class ModelLoader
    {
        public static Task<SirModel> LoadJson(string fileName)
            // we do not want to switch threads here, that is job of the caller
            => JsonSerialization.DeserializeModel(fileName);
    }
}
