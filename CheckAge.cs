using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_5
{
    internal class CheckAge
    {
        //Create a custom exception InvalidAgeException that is thrown when a user enters an age less than 18.

        public void ValidateAge()
        {
            try
            {
                Console.WriteLine("Enter your age");
                int age = Convert.ToInt32(Console.ReadLine());

                if (age < 18)
                {
                    throw new InvalidAgeException("Age Must be More than 18");

                }

                Console.WriteLine("Valid age");
            }


            catch (InvalidAgeException ex)
            {
                Console.WriteLine("Error" + ex.Message);

            }


            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid number.");
            }


        }


    }
}
