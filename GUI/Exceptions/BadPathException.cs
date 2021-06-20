using System;

namespace Project.Exceptions
{
    public class BadPathException : Exception
    {
        public BadPathException(string message) : base(message) { }
    }
}
