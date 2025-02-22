using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_3
{
    internal class UsingLambdaEx
    {
        //Q- 4.
        //4.1 Even/Odd Checker
        //Create a lambda expression that checks whether a number is even or odd.

        public void EvenOdd()
        {

            Func<int, bool> isEven = num => num % 2 == 0;

            Console.Write("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(isEven(number) ? "Even" : "Odd");


        }


        //5.String Length Comparison
        //Use a lambda expression to compare two strings based on their lengths.

        public void StringLengthCom()
        {

            var compareLength = (string s1, string s2) => s1.Length - s2.Length;
            Console.Write("Enter  string 1: ");
            string str1 = Console.ReadLine();

            Console.Write("Enter string 2: ");
            string str2 = Console.ReadLine();

            int result = compareLength(str1, str2);

            if (result == 0)
            {
                Console.WriteLine("Same String length");

            }
            else if (result > 1)
            {
                Console.WriteLine("String 1 is longer");
            }
            else
            {

                Console.WriteLine("String 2 is longer");
            }

        }
        //__________________________________________________________________
        

        //Q-7
        //7.1 Number Transformation
        //Given a list of integers, use a lambda expression to:
        //Multiply each number by 2.
        //Remove numbers less than 10.


        public void NumberTransformation()
        {
            List<int> numbers = new List<int> { 3, 5, 7, 10, 12, 15 };

            var result = numbers
                         .Select(n => n * 2)  
                         .Where(n => n >= 10) 
                         .ToList();

            Console.WriteLine("Transformed Numbers: " + string.Join(", ", result));

        }

        //________________________________________________________________________


        //7.2 Find Maximum
        //Write a lambda expression to find the maximum of two numbers.
        public void MaxOfTwo()
        {
            var maxNum = (int a, int b) => a > b ? a : b;

            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Maximum number: {maxNum(num1, num2)}");


        }













    }
}
