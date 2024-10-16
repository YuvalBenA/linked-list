using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedList
{
    class ItemOfWrongeTypeException : SystemException
    {
        public ItemOfWrongeTypeException(): base("The item is of the wrong type.") {}
        public IndexOutOfRangeException(string? message): base(message) {}
        public IndexOutOfRangeException(string? message, Exception? innerException): base(message, innerException) {}
    }
}
