using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_5
{
    //5. Use NUnit to write unit tests for a simple calculator class that performs addition, subtraction, multiplication, and division.

    public class CalculatorOperations
    {
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
        public double Division(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return (double) a / b;
        }

    }
}
