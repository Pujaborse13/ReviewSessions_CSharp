using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ReviewSession_4
{
    //Q.11)JSON File and Parse Data: Read a JSON file, parse the content, and display it.

    public class JSONFileOperations
    {
        public string path = @"D:\AcessMeditech\ReviewSession_4\ReviewSession_4\JSONFileOperations.json";

        public void CreateFile()
        {

            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                File.Create(path);
                Console.WriteLine("JSON File created successfully");
            }

        }

        public void WriteInJSONFile()
        {
            var EmpData = new List<EmployeeJSONOprations> {
            new EmployeeJSONOprations { EmployeeId=101, EmployeeName="Puja",Salary=5600},
            new EmployeeJSONOprations{ EmployeeId=102, EmployeeName="Asmita",Salary=6000},
            new EmployeeJSONOprations{ EmployeeId=103, EmployeeName="Komal",Salary=7000}
            };


            string jsonData = JsonConvert.SerializeObject(EmpData, Formatting.Indented);
            File.WriteAllText(path, jsonData);
            Console.WriteLine("Data written in JSON FILE  sucessfully");
        }

        public void readJSONFile()
        {
        
            string jsonRead = File.ReadAllText(path);
            var deserializedData = JsonConvert.DeserializeObject<List<EmployeeJSONOprations>>(jsonRead);

            foreach (var record in deserializedData)
            {
                Console.WriteLine($"EmpId ={record.EmployeeId}, EmpName={record.EmployeeName}, Salary = {record.Salary}");
            }
        }


    }



    }



