using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ReviewSession_5
{
   // 1. Prime Number Checker
   //Write a console app to check if a number is prime.Implement input validation and ensure proper error handling.

    internal class PrimeNumberChecker
    {
        public void CheckPrimeNumber()
        {
            Console.Write("Enter the number ");
            string input = Console.ReadLine();


            if (int.TryParse(input, out int number) && number > 0)
            {
                if (IsPrime(number))
                    Console.WriteLine("Number is Prime");

                else
                    Console.WriteLine("Number is Not Prime");

            }
            else {
                Console.WriteLine("Invalid Input !");
            
            }

            static bool IsPrime(int number)
            {
                if(number < 2)
                    return false;
                for (int i = 2; i * i <= number; i++)
                { 
                    if(number % i == 0 )
                        return false;

                }
                return true;

            }

        
        }


    }
}
