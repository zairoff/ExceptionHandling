using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Exceptions
{
    public class ConflictException : Exception
    {
        public ConflictException()
        {
        }

        public ConflictException(string message) : base(message)
        {
        }
    }
}
