using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession1_Puja
{
   internal class FibonacciSeries
    {
        public void FibonacciSeriesUptoN()
        {
            Console.WriteLine("Enter the N term :");
            int n = int.Parse(Console.ReadLine());

            int n1 = 0;
            int n2 = 1;

            int count = 0;

            Console.WriteLine("Fibonacci Series");
            while (count < n)
            {
                Console.Write(n1 + " ");
                int next = n1 + n2;
                n1 = n2;
                n2 = next;
                count++;
         
            
            }
        
        }

    }
}
