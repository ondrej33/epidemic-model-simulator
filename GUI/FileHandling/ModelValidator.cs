using System.IO;
using System.Text.RegularExpressions;


namespace Project.FileHandling
{
    /* Validates the format of file with model description, 
     * at this time accepts SIR and SIRS model types */
    public static class ModelValidator
    {
        /* Checks if the whole file meets the given format. */
        public static bool ValidateMyFormat(string fileName)
        {
            string fileContent = File.ReadAllText(fileName);
            // Sir and Sirs are very similar, only differs in type and Timmu (which is missing in Sir)

            var patternSIR = new Regex(@"\AModelType:[ ]*SIR[ ]*(\n|\r\n)" +
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

            var patternSIRS = new Regex(@"\AModelType:[ ]*SIRS[ ]*(\n|\r\n)" +
                                        @"-[ ]*(\n|\r\n)" +
                                        @"N:[ ]*(\d)+[ ]*(\n|\r\n)" +
                                        @"Tinf:[ ]*(\d)+[ ]*(\n|\r\n)" +
                                        @"Timmu:[ ]*(\d)+[ ]*(\n|\r\n)" +
                                        @"R0:[ ]*(\d+|\d+\.\d+)[ ]*(\n|\r\n)" +
                                        @"Time:[ ]*(\d)+[ ]*(\n|\r\n)" +
                                        @"-[ ]*(\n|\r\n)" +
                                        @"S:[ ]*(\d)+[ ]*(\n|\r\n)" +
                                        @"I:[ ]*(\d)+[ ]*(\n|\r\n)" +
                                        @"R:[ ]*(\d)+[ ]*(\n|\r\n)" +
                                        @"-[ ]*(\n|\r\n|$)" +
                                        @"(Event:[ ]*(\d+|\d+\.\d+)+[ ]*,[ ]*(R0|Tinf)[ ]*=[ ]*(\d+|\d+\.\d+)[ ]*(?:\n|\r\n|$))*\Z");

            // lets check if we have match
            var oneMatched = patternSIR.Match(fileContent).Success || patternSIRS.Match(fileContent).Success;
            if (!oneMatched)
            {
                return false;
            }
            return true;
        }
    }
}
