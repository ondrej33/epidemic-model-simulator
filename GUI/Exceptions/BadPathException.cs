using System;

namespace GUI.Exceptions
{
    public class BadPathException : Exception
    {
        public BadPathException(string message) : base(message) { }
    }
}
