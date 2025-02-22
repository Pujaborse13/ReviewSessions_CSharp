using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_2
{
    internal class SortByNameAge
   {
        public void SortList() {
            List<(string Name, int Age)> students = new List<(string, int)>
            {
                ("Puja", 21),
                ("Asmita", 22),
                ("Disha", 23),
                ("Komal", 20),
                ("Pratibha", 22)
            };

            //Sort the List of Names in Descending Order

            var sortByNameDesc = students.OrderByDescending(s => s.Name).ToList();
            Console.WriteLine("Sorted by Name Descending :");
            sortByNameDesc.ForEach(s => Console.WriteLine($"Name: {s.Name}, Age: {s.Age}"));


            //Sort a List of Students by Name and Age
            //orde byname
            var sortByName = students.OrderBy(s => s.Name).ToList();
            Console.WriteLine("Sorted by Name:");
            sortByName.ForEach(s => Console.WriteLine($"Name: {s.Name}, Age: {s.Age}"));

            //order by age
            var sortedByAge = students.OrderBy(s => s.Age).ToList();
            Console.WriteLine("Sorted by Age:");
            sortedByAge.ForEach(s => Console.WriteLine($"Name: {s.Name}, Age: {s.Age}"));






        }
    }
}

