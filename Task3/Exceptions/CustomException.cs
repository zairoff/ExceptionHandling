using System;
using System.Collections.Generic;
using System.Text;

namespace Task3.Exceptions
{
    [Serializable]
    public class CustomException : Exception
    {
        public CustomException()
        {
        }

        public CustomException(string message) : base(message)
        {
        }
    }
}
