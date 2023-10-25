using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13.Models
{
    internal class InvalidNameException : Exception
    {
        public InvalidNameException(string message) : base(message)
        {

        }

    }

    internal class InvalidSurNameException : Exception
    {
        public InvalidSurNameException(string message) : base(message)
        {

        }

    }
    internal class InvalidPasswordException : Exception
    {
        public InvalidPasswordException(string message) : base(message)
        {

        }

    }

    internal class BlogNotFoundExceptions : Exception
    {
        public BlogNotFoundExceptions(string message) : base(message)
        {

        }

    }
}
