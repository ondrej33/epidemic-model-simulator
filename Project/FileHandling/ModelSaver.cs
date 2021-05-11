using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.FileHandling
{
    /* Class that will be used to save (convert) models in different formats */
    public class ModelSaver
    {
        public static Task SaveJson(SirModel model, string fileName)
            // we do not want to switch threads here, that is job of the caller
            => JsonSerialization.SerializeModel(model, fileName);

    }
}
