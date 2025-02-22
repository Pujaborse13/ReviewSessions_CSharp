using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_2
{
    internal class CalculatorMethodOverloading{
        public int Add(int a, int b){
            return a + b;
        }

        public double Add(double a, double b){
            return a + b;
        }

        public int Add(int a, int b, int c){
            return a + b + c;
        }

        public void Output(){

            Console.WriteLine("Add (int int)  :" + Add(5, 10));
            Console.WriteLine("Add (double double)  :" +Add(5.5, 10.2));
            Console.WriteLine("Add (int int int )  :" + Add(5, 10, 20));

        }


    }
}
