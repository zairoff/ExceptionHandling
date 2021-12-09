using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Exceptions
{
    [Serializable]
    public class InvalidUserException : Exception
    {
        public InvalidUserException()
        {
        }

        public InvalidUserException(string message) : base(message)
        {
        }
    }
}
