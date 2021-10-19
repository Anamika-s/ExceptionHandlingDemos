using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandlingDemo
{
    class CustomException : Exception
    {
        public CustomException(string message) : base (message)
        { }
    }
}
