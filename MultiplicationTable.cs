using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession1_Puja
{
    internal class MultiplicationTable
    {

        public void MultiplicationTableofGivenNum()
        {
            Console.Write("Enter the Number :");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{n} * {i} = {n * i}");

            }
        }
    }
}

