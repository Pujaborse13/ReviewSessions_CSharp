using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_2
{
    internal class FindMax{
        public static T FindMaxNum<T>(T[] array) where T : IComparable<T>{ 
            T max = array[0];

            foreach (T item in array) {
                if (item.CompareTo(max) > 0)   
                    max = item;
            }

            return max;

        }

        public void Input()
        {
            int[] intArray = { 1, 5, 3, 9, 2 };
            double[] doubleArray = { 2.5, 7.8, 1.2, 6.4 };
            string[] stringArray = { "hiee", "puja", "Borse" };

            Console.WriteLine("Max Int: " + FindMaxNum(intArray));
            Console.WriteLine("Max Double: " + FindMaxNum(doubleArray));
            Console.WriteLine("Max String: " + FindMaxNum(stringArray));


        }


    }
}
