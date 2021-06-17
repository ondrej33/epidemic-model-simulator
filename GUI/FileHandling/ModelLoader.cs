using GUI.Models;
using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GUI.FileHandling
{
    public class ModelLoader
    {
        /* Checks format and then loads model, must have defined format
         * If format is not correct, throws */
        public static Task<BaseModel> LoadModel(string fileName)
        {
            if (!ModelValidator.ValidateMyFormat(fileName))
            {
                throw new ArgumentException("Incorrectly formatted file.");
            }
            return LoadMyFormatAsync(fileName);
        }

        public static Task<BaseModel> LoadJson(string fileName)
            // we do not want to switch threads here, that is job of the caller
            => JsonSerialization.DeserializeModel(fileName);

        /* Loads the model from a file that was validated before */
        public static BaseModel LoadMyFormat(string fileName)
        {
            // solve the model ID loading / assigning

            // load the content of the file
            string fileContent = File.ReadAllText(fileName);

            // define the regexes
            var SirsTypeRegex = new Regex(@"ModelType:[ ]*SIRS");
            var NRegex = new Regex(@"N:[ ]*(\d+)");
            var TinfRegex = new Regex(@"Tinf:[ ]*(\d+)");
            var R0Regex = new Regex(@"R0:[ ]*(\d+|\d+\.\d+)");
            var TimeRegex = new Regex(@"Time:[ ]*(\d+)");

            var SRegex = new Regex(@"S:[ ]*(\d+)");
            var IRegex = new Regex(@"I:[ ]*(\d+)");
            var RRegex = new Regex(@"R:[ ]*(\d+)");

            var eventRegex = new Regex(@"Event:[ ]*(\d+|\d+\.\d+)[ ]*,[ ]*(R0|Tinf)[ ]*=[ ]*(\d+|\d+\.\d+)");

            // find the regex matches
            var SirsTypeMatch = SirsTypeRegex.Match(fileContent);
            var NMatch = NRegex.Match(fileContent);
            var TinfMatch = TinfRegex.Match(fileContent);
            var R0Match = R0Regex.Match(fileContent);
            var TimeMatch = TimeRegex.Match(fileContent);
            var SMatch = SRegex.Match(fileContent);
            var IMatch = IRegex.Match(fileContent);
            var RMatch = RRegex.Match(fileContent);

            var eventMatches = eventRegex.Matches(fileContent);

            // now we will put all of that to the new model
            // we know that all parsing should be fine, because model of the structure of regexes

            BaseModel model;
            // if SirsModelType matched, we know we have SIRS, otherwise must be SIR
            if (SirsTypeMatch.Success)
            {
                model = new SirsModel();
                // and now that we have SIRS, lets add its one additional parameter
                var TimmuRegex = new Regex(@"Timmu:[ ]*(\d+)");
                var TimmuMatch = TimmuRegex.Match(fileContent);
                (model as SirsModel).TimeImmune = int.Parse(TimmuMatch.Groups[1].Value);
            }
            else
            {
                model = new SirModel();
            }

            model.PopulationSize = int.Parse(NMatch.Groups[1].Value);
            model.TimeInfection = int.Parse(TinfMatch.Groups[1].Value);
            model.R0 = int.Parse(R0Match.Groups[1].Value);
            model.TimeToSimulate = int.Parse(TimeMatch.Groups[1].Value);

            model.SusceptibleInit = int.Parse(SMatch.Groups[1].Value);
            model.InfectedInit = int.Parse(IMatch.Groups[1].Value);
            model.RemovedInit = int.Parse(RMatch.Groups[1].Value);

            foreach (Match match in eventMatches)
            {
                double time = int.Parse(match.Groups[1].Value);
                ParameterType param;
                Enum.TryParse(match.Groups[2].Value, out param);
                double newVal = int.Parse(match.Groups[3].Value);

                model.Events.Add((param, time, newVal));
            }
            // at the end we will sort the events by time
            model.Events = model.Events.OrderBy(triplet => triplet.time).ToList();
            return model;
        }

        /* Async wrapper for above method */
        public static async Task<BaseModel> LoadMyFormatAsync(string fileName)
        {
            var model = await Task.Run(() => LoadMyFormat(fileName));
            return model;
        }

    }
}
