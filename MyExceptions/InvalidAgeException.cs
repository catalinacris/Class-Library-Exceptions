using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExceptions
{
    public class InvalidAgeException : ApplicationException
    {
        public InvalidAgeException(string message = "The AGE should not be greater then 100") : base(message)
        {
          
        }


    }
}
