using System;
using MyExceptions;
 

namespace AssignmentExceptions
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                Dog dog = new Dog(-2, "lola");
            }
            catch (InvalidNegativeAgeException ex)
            {

                Console.WriteLine(ex.Message);
            }
            try
            {
                Dog dog = new Dog(111, "lola");
            }
            catch (InvalidAgeException inae)
            {
                Console.WriteLine(inae.Message);
            }
            try
            {
                Dog dog = new Dog(7, "a");
            }
            catch (InvalidNameException ine)
            {

                Console.WriteLine(ine.Message);
            }
        }
    }
}
