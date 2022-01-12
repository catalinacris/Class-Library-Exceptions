using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyExceptions;

namespace AssignmentExceptions
{
    public class Dog
    {
        private int age; //throw ArgumentException for negative age 
                         //throw ApplicationException for age greater than 100
        private string name; //throw ApplicationException for name length lower than 2

        public Dog(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if(value >= 0 && value <= 100)
                {
                    this.age = value;
                }
                else if (value < 0)
                {
                    throw new InvalidNegativeAgeException();
                    
                }
                else// age greater than 100
                {
                    throw new InvalidAgeException();
                    
                }

            }
        }

        public string Name
        {
             get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 2)
                {
                    this.name = value;
                }
                else //name length lower than 2
                {
                    throw new InvalidNameException();
                    
                }
            }
        }
    }
}
