using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ReviewSession_3
{
    public  class DuplicateWord
    {    //1

        //1.4 Find Duplicate Words
        //Write a Regex to find all duplicate words in a sentence(e.g., "This is is a test test").

        public void FindDuplicate()
        {

            Console.WriteLine("Enter Sentence");
            string sentence = Console.ReadLine();

            Regex  senRegex = new Regex(@"\b(\w+)\s+\1\b", RegexOptions.IgnoreCase);
            MatchCollection matches = senRegex.Matches(sentence);

            if (matches.Count > 0)
            {
                Console.WriteLine("Duplicate words found:");
                foreach (Match match in matches)
                {
                    Console.WriteLine($" - {match.Value}");
                }
            }
            else
            {
                Console.WriteLine("No duplicate words found.");
            }


        }


    }
}
