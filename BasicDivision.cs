using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_3
{
    // Q- 2)
    // 2.1 Basic Division Program
    //Write a program that takes two integers and divides them.
    //Handle exceptions for : Division by zero , Invalid input format.

    public class BasicDivision
    {   

        public double DivisionNum()
        {
            try
            {
                
                Console.Write("Enter first number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                if (num2 == 0)
                {
                    throw new DivideByZeroException("Error: Cannot divide by zero.");
                }

                double result = (double)num1 / num2;
                Console.WriteLine($"Result: {result}");
                return result;
            }
            catch (FormatException){
                Console.WriteLine("Error: Invalid input! Please enter a valid integer.");
            }
        
            return 0; 
       
        }


    }
}
