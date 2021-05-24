using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;


namespace Project.FileHandling
{
    public static class ModelValidator
    {
        public static bool ValidateMyFormat(string fileName)
        {
            string fileContent = File.ReadAllText(fileName);
            var modelFilePattern = new Regex(@"\AModelType:[ ]+(SIR|SIRS)[ ]+\n
                                               -[ ]+\n
                                               N:[ ]+(\d)+[ ]+\n
                                               Tinf:[ ]+(\d)+[ ]+\n
                                               RO:[ ]+(\d)+[ ]+\n
                                               Time:[ ]+(\d)+[ ]+\n
                                               -[ ]+\n
                                               S:[ ]+(\d)+[ ]+\n
                                               I:[ ]+(\d)+[ ]+\n
                                               R:[ ]+(\d)+[ ]+\n
                                               -[ ]+\n
                                               (Event:[ ]+(\d)+[ ]+,[ ]+(R0|Tinf|N)=(\d)+[ ]+(?:\n|\r\n|$))*\Z");

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
