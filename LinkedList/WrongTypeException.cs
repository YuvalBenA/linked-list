using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    
    class WrongTypeException : SystemException
    {
        public WrongTypeException(): base("The item is of the wrong type.") {}
        public WrongTypeException(string? message): base(message) {}
        public WrongTypeException(string? message, Exception? innerException): base(message, innerException) {}
    }
}
