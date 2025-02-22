using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_3
{
    //2.2  Custom Age Validator
    //Write a program to input the age of a person.

    public class AgeValidator
    {
        public void ValidAge()
        {
            Console.Write("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            try
            {
                if (age < 0 || age > 150)
                {
                    throw new InvalidAgeException("Error: Age must be between 0 and 150 only");

                }
                Console.WriteLine($"Valid  Age");
            }
            catch (InvalidAgeException ex)

            {
                Console.WriteLine(ex.Message);

            }


        }


    }
}
