using System;

namespace GUI.Exceptions
{
    class BadModelFormatException : Exception
    {
        public BadModelFormatException(string message) : base(message) { }
    }
}
