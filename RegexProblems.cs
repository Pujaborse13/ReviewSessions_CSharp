using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReviewSession_4
{
    internal class RegexProblems
    {
        //Q.1 Validate Email Format: Write a function using Regex to validate email addresses
            //(e.g., example@domain.com).
        public void ValidateEMail()
        {
            Console.Write("Enter an email: ");
            string inputEmail = Console.ReadLine();

            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            Match match = Regex.Match(inputEmail, emailPattern);

            if (match.Success){
                Console.WriteLine("Valid Email Id");
            }
            else
            {
                Console.WriteLine("Invalid Email id");
            }


        }



        //Q.3 > Check Strong Password: Validate a password that must contain at least 1 uppercase,
        //1 lowercase, 1 digit, and 1 special character.
        public void ValidateStrongPassword()
        {
            Console.Write("Enter a Password: ");
            string inputPassword = Console.ReadLine();

            string passwordPattern = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";

            Match match = Regex.Match(inputPassword, passwordPattern);

            if (match.Success)
            {
                Console.WriteLine("Valid Password");

            }
            else
            {
                Console.WriteLine("Invalid password");
            }
        }

        // Q.2) Extract Phone Numbers: Parse a string and extract 10 - digit phone numbers.

        public void ExtractPhoneNo()
        {
            string inputString = "puja borse my phone no is 9821443771";

            string phoneNoPattern = @"\d{10}";

            MatchCollection matches = Regex.Matches(inputString, phoneNoPattern);

            if (matches.Count > 0)
            {
                Console.WriteLine("Extracted phone no : ");
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
            else
            {
                Console.WriteLine("No valid phone no in given string");
            }

        }

        //Q4) Find Dates in Text: Extract dates in formats like dd/mm/yyyy or yyyy-mm-dd.
        public void ExtractDate()
        {
            string inputTxt = "my birth date 12/08/2002 and 2002-08-13";

            string datePattern = @"\b(?:\d{2}/\d{2}/\d{4}|\d{4}-\d{2}-\d{2})\b";

            MatchCollection matches = Regex.Matches(inputTxt,datePattern);

            if (matches.Count > 0)
            {
                Console.WriteLine("Exracted date");
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);

                }
            }

            else {
                Console.WriteLine("Date not found");
            }

        }



        //Q.5 Replace Multiple Whitespaces: Convert multiple spaces in a string into a single space.

        public void ReplaceMultipleWhitespaces()
        { 
            string inputTxt= "This   is  a  given    string   with   multiple   spaces";

            string replaceStr = Regex.Replace(inputTxt, @"\s+", " ");


            Console.WriteLine("Given input text: " + inputTxt);
            Console.WriteLine("Output : " + replaceStr);



        }














    }













}
