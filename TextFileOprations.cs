using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_4
{
    //Q.10) Read and Write to a File: Write a program to read from and write to a text file.

    public class TextFileOprations
    {
        public string filePath = @"D:\AcessMeditech\ReviewSession_4\ReviewSession_4\TextFileOperations.txt";


        public void WriteInfile()
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine("File Not Exists");
            }

            Console.Write("Enter Employee Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Employee Address: ");
            string address = Console.ReadLine();

            Console.Write("Enter Employee Contact Number: ");
            string contact = Console.ReadLine();


            using (StreamWriter sw = new StreamWriter(filePath))
            {
                sw.WriteLine("Employee Name" + name);
                sw.WriteLine("Address: " + address);
                sw.WriteLine("Contact: " + contact);
            }

            Console.WriteLine("\nEmployee details saved successfully in EmployeeData.txt");



        }




        public void ReadFile()
        {

            if (!File.Exists(filePath))
            {
                Console.WriteLine("File Not Exists");
            }

            using (StreamReader sr = new StreamReader(filePath))
            {
                string content = File.ReadAllText(filePath);
                Console.WriteLine(content);

            }


        }

     }
}
