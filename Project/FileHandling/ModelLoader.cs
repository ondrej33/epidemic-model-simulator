using Project.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
                case FormatType.MyFormat:
                    if (!ModelValidator.ValidateMyFormat(fileName))
                    {
                        throw new ArgumentException("Incorrectly formatted file.");
                    }
                    return LoadMyFormatAsync(fileName);
                default:
                    throw new ArgumentException("Incorrect format type.");
            }
        }

        public static Task<SirModel> LoadJson(string fileName)
            // we do not want to switch threads here, that is job of the caller
            => JsonSerialization.DeserializeModel(fileName);

        /* Loads the model from a file that was validated before */
        public static SirModel LoadMyFormat(string fileName)
        {
            // solve the model ID loading / assigning

            // load the content of the file
            string fileContent = File.ReadAllText(fileName);

            // define the regexes
            var modelTypeRegex = new Regex(@"ModelType:[ ]+(SIR|SIRS)");
            var NRegex = new Regex(@"N:[ ]+(\d+)");
            var TinfRegex = new Regex(@"Tinf:[ ]+(\d+)");
            var R0Regex = new Regex(@"R0:[ ]+(\d+)");
            var TimeRegex = new Regex(@"Time:[ ]+(\d+)");

            var SRegex = new Regex(@"S:[ ]+(\d+)");
            var IRegex = new Regex(@"I:[ ]+(\d+)");
            var RRegex = new Regex(@"R:[ ]+(\d+)");

            var eventRegex = new Regex(@"Event:[ ]+(\d+)[ ]+,[ ]+(R0|Tinf|N)=(\d+)");

            // TODO - check modelTypeRegex and choose the right type of the model

            // find the regex matches
            var NMatch = NRegex.Match(fileContent);
            var TinfMatch = TinfRegex.Match(fileContent);
            var R0Match = R0Regex.Match(fileContent);
            var TimeMatch = TimeRegex.Match(fileContent);
            var SMatch = SRegex.Match(fileContent);
            var IMatch = IRegex.Match(fileContent);
            var RMatch = RRegex.Match(fileContent);

            var eventMatches = eventRegex.Matches(fileContent);

            // putting all of that to the new model
            // we know that all parsing should be fine, because model of the structure of regexes
            var sirModel = new SirModel();
            sirModel.PopulationSize = int.Parse(NMatch.Groups[1].Value);
            sirModel.TimeInfection = int.Parse(TinfMatch.Groups[1].Value);
            sirModel.R0 = int.Parse(R0Match.Groups[1].Value);
            sirModel.TimeToSimulate = int.Parse(TimeMatch.Groups[1].Value);

            sirModel.SusceptibleInit = int.Parse(SMatch.Groups[1].Value);
            sirModel.InfectedInit = int.Parse(IMatch.Groups[1].Value);
            sirModel.RemovedInit = int.Parse(RMatch.Groups[1].Value);

            foreach (Match match in eventMatches)
            {
                double time = int.Parse(match.Groups[1].Value);
                ParameterType param;
                Enum.TryParse(match.Groups[2].Value, out param);
                double newVal = int.Parse(match.Groups[3].Value);

                sirModel.Events.Add((param, time, newVal));
            }
            // at the end we will sort the events by time
            sirModel.Events = sirModel.Events.OrderBy(triplet => triplet.time).ToList();
            return sirModel;
        }

        /* Async wrapper for above method */
        public static async Task<SirModel> LoadMyFormatAsync(string fileName)
        {
            var model = await Task.Run(() => LoadMyFormat(fileName));
            return model;
        }

    }
}
