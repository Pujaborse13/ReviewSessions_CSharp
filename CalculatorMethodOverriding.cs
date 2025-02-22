using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_2
{   //Method Overriding : Two Classes  CalculatorMethodOverriding ,Calculator2
    //which overrieds method MathOperations() for 2 differant operation Addition and Multiplication
    public class CalculatorMethodOverriding{
                    public virtual int MathOperations(int a, int b){
                        Console.WriteLine("Addition");
                          return a + b;
        
                    }

                }
    class Calculator2 : CalculatorMethodOverriding
    {
        public override int MathOperations(int a, int b)
        {
            Console.WriteLine("Multiplication");
            return a * b;

        }


    }
}
