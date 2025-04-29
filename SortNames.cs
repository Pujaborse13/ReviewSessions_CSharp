using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_5
{
    internal class SortNames
    {
        //2. Sorting Names
        //Use a C# collection like List<T> to store a list of names.
        //Sort them alphabetically without using built-in sorting methods.


        public void PrintSortedList()
        {
            List<string> nameList = new List<string> { "Puja", "Asmita", "Pratibha", "Disha" ,"Mansi" };

            Console.WriteLine("Orignal List");
            PrintNames(nameList);


            SortName(nameList);


            Console.WriteLine("\nSorted Names:");
            PrintNames(nameList);

        }
         static void SortName(List<string> nameList)
         { 
            int n = nameList.Count;

             for (int i = 0; i < n - 1; i++)
             {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (nameList[j].CompareTo(nameList[j + 1]) > 0)
                    {
                        string temp = nameList[j];
                        nameList[j] = nameList[j + 1];
                        nameList[j + 1] = temp;

                    }


                }


             }
            
            
         }

            static void PrintNames(List<string> names)
            {
                foreach (var name in names)
                {
                    Console.WriteLine(name);
                }
            }

        
    }
}
