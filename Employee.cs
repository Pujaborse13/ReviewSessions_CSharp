using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession_2
{
     class Employee
     {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        
        public Employee(int id, string name, string department)   
        {
            Id = id;
            Name = name;
            Department = department;
        }

        public void Display()  
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Department: {Department}");
        }
     }

    class EmployeeData
    {       //List To Store Employee Data.
            private List<Employee> employees = new List<Employee>();

            //to Add Employee
            public void AddEmployee(Employee emp) {
                employees.Add(emp);
          
            }

          //To Remove Employee
            public void RemoveEmployee(int id)
            {
            Employee emp = employees.Find(e => e.Id == id);

            if (emp != null){
                employees.Remove(emp);
                Console.WriteLine($"Employee with ID {id} removed.");
            }

            else{
                Console.WriteLine("Employee Not Found");
             }
           }


        //Search Employee
       public Employee SearchById(int id)
       {
            Console.WriteLine("Employee found by given ID");
            return employees.Find(e => e.Id == id);
       }

        //Display Employee
        public void DisplayEmp()
        {
                if (employees.Count == 0){
                    Console.WriteLine("No Employee Found");
                    return;

                }

                Console.WriteLine("Employee List :");
            foreach (Employee emp in employees){
                emp.Display();

            }

        }
    }

}
