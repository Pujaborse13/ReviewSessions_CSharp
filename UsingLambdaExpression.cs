using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_4
{
    //Q.7) Check Palindrome Using Lambda: Create a lambda expression to check if a string is a palindrome. 
    internal class UsingLambdaExpression
    {
        public void PalindromeUsingLambdaEx()
        {

            Func<string, bool> isPalindrome = str => str == new string(str.Reverse().ToArray());

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Console.WriteLine(isPalindrome(input) ? "Palindrome" : "Not a Palindrome");

        }


    }
}
