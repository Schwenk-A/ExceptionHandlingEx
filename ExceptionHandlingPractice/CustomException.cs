using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingPractice
{
    internal class CustomException : Exception
    {
        //this is a templated example of a custom exception. Use this for creating new custom exceptions
        public CustomException()
        {

        }

        //the base is calling this constructor in the exception class which will set the message
        //to the CustomException.Message property that we inherit from the exception class.

        public CustomException(string message) : base(message)
        {
            //we pass in string message and it gets sent to the base class which is exception and 
            //uses its constructor that takes in one string.
            //
        }

        public CustomException(string message, Exception inner)
                : base(message, inner)
        {
        }

    }
}
