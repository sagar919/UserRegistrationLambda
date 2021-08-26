using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationRegex
{
    public class InvalidNameException : Exception
    {
        public InvalidNameException(string message) : base(message)
        {

        }
    }

    public class InvalidMobileNumberException : Exception
    {
        public InvalidMobileNumberException(string message) : base(message)
        {

        }
    }

    public class InvalidEmailException : Exception
    {
        public InvalidEmailException(string message) : base(message)
        {

        }
    }

    public class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(string message) : base(message)
        {

        }
    }
}
