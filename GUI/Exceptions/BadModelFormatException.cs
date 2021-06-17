using System;

namespace Project.Exceptions
{
    class BadModelFormatException : Exception
    {
        public BadModelFormatException(string message) : base(message) { }
    }
}
