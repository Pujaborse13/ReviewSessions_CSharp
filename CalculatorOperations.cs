using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_3
{
    public class CalculatorOperations
    {
        //Q - 6
        //6.1 Test Calculator Class
        //Write a Calculator class with methods for addition, subtraction, multiplication, and division.
        // Write NUnit tests to validate the correctness of these methods.

        public int Addition(int a, int b)
        { return a + b; }

        public int Subtration(int a, int b)
        {
            return a - b;
        }
        public int Multiplication(int a, int b)
        {
            return (a * b);

        }
        public int Division(int a, int b)
        {
            return a / b;
        }



    }
}
