using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession1_Puja
{
    internal class SwapInteger
    {
        public void SwapTwoInteger()
        {

            int a = 10;
            int b = 20;

            a = a + b;   //30
            b = a - b;   //10
            a = a - b;   //20

            Console.WriteLine($"a :{a}");
            Console.WriteLine($"b :{b}");




        }

    }
}
