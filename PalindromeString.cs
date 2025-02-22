using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_3
{
    public  class PalindromeString
    {
        public bool IsPalindrome(string input)
        {
            if(string.IsNullOrEmpty(input)) 
                return false;

            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != input[right])
                    return false;

                left++;
                right--;
            }
            return true;

        }
    }
}
