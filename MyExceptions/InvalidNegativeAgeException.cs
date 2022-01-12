using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptions
{
    public class InvalidNegativeAgeException : InvalidNameException
    {
        public InvalidNegativeAgeException(string message = "The AGE should not be less then 0") : base(message)
        {

        }
    }
}
