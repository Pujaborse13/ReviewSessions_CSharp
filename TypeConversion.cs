using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession1_Puja
{
    internal class TypeConversion
    {
        public void TypeConversionImplicitAndExplicit()
        {

            //implicit type Conversion
            int num = 10;
            double toDouble = num;
            Console.WriteLine("Implicit Conversion int to double: " + toDouble);


            //Explicit Type Conversion
            double num2 = 9.99;
            int toInt = (int)num2; 
            Console.WriteLine("Explicit Conversion (double to int): " + toInt);

        }

    }
}
