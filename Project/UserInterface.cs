using System;

namespace Project
{
    /* Only class that will be comunicating with the user directly */
    public static class UserInterface
    {
        /* Initial communication, receives input path */
        public static string GetInputPath()
        {
            Console.Write(
                "Hello there! Welcome to the Epidemic model simulator!\n" +
                "Please enter the name of the file with paths to all of the model files:\n" +
                "> "
            );
            string path = Console.ReadLine().Trim();
            return path;
        }

        /* Informs user about how many paths were obtained */
        public static void InformAboutNumberPaths(int fileCount)
            => Console.WriteLine($"{fileCount} paths were obtained from the input.");

        public static void WriteError(string message)
            => Console.WriteLine(message);
    }
}
