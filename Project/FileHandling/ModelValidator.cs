using System.IO;
using System.Text.RegularExpressions;


namespace Project.FileHandling
{
    public static class ModelValidator
    {
        public static bool ValidateMyFormat(string fileName)
        {
            string fileContent = File.ReadAllText(fileName);
            var modelFilePattern = new Regex(@"\AModelType:[ ]*(SIR|SIRS)[ ]*(\n|\r\n)" +
                                             @"-[ ]*(\n|\r\n)" +
                                             @"N:[ ]*(\d)+[ ]*(\n|\r\n)" +
                                             @"Tinf:[ ]*(\d)+[ ]*(\n|\r\n)" +
                                             @"R0:[ ]*(\d+|\d+\.\d+)[ ]*(\n|\r\n)" +
                                             @"Time:[ ]*(\d)+[ ]*(\n|\r\n)" +
                                             @"-[ ]*(\n|\r\n)" +
                                             @"S:[ ]*(\d)+[ ]*(\n|\r\n)" +
                                             @"I:[ ]*(\d)+[ ]*(\n|\r\n)" +
                                             @"R:[ ]*(\d)+[ ]*(\n|\r\n)" +
                                             @"-[ ]*(\n|\r\n|$)" +
                                             @"(Event:[ ]*(\d+|\d+\.\d+)+[ ]*,[ ]*(R0|Tinf)[ ]*=[ ]*(\d+|\d+\.\d+)[ ]*(?:\n|\r\n|$))*\Z");

            // lets check if we have match
            var wholeStringMatch = modelFilePattern.Match(fileContent);
            if (!wholeStringMatch.Success)
            {
                return false;
            }
            return true;
        }
    }
}
