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
        /* Loads model from arbitrary formatted file, format given by arg
         * If format is not correct for corresponding type, throws */
        public static Task<SirModel> LoadModel(string fileName, FormatType formatType)
        {

            // TODO
            switch (formatType) { 
                case FormatType.JSON:
                    return LoadJson(fileName);
                case FormatType.XML:
                    break;
                case FormatType.MyFormat:
                    if (!ModelValidator.ValidateMyFormat(fileName))
                    {
                        throw new ArgumentException("Incorrectly formatted file.");
                    }
                    break;
                default:
                    throw new ArgumentException("Incorrect format type.");
            }
            // TODO delete
            return LoadJson(fileName);
        }

        public static Task<SirModel> LoadJson(string fileName)
            // we do not want to switch threads here, that is job of the caller
            => JsonSerialization.DeserializeModel(fileName);
    }
}
