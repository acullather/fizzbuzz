using System;

namespace FizzBuzz
{
    public class FizzBuzzException : Exception
    {
        public FizzBuzzException() 
            : base()
        { }

        public FizzBuzzException(string message)
            : base(message)
        { }

        public FizzBuzzException(string message, Exception innerException)
            : base(message, innerException)
        { }
    }
}
