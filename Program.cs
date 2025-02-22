using ReviewSession_2;

public class Program
{
    static void Main(string[] args)
    { 
        //1. find Max
        FindMax  findMax = new FindMax();
        findMax.Input();
    
        //2. Overloading
        CalculatorMethodOverloading calculatorMethod = new CalculatorMethodOverloading();
        calculatorMethod.Output();


        //3. Overriding
        CalculatorMethodOverriding cal1 = new CalculatorMethodOverriding();
        Console.WriteLine("Calculator1 : Addition " + cal1.MathOperations(10,20));

        CalculatorMethodOverriding cal2 = new CalculatorMethodOverriding();
        Console.WriteLine("Calculator2 : Multiplication " + cal2.MathOperations(30, 20));

        //4 . Sort By Age Name
        SortByNameAge sortByNameAge = new SortByNameAge();
        sortByNameAge.SortList();


        //---------------------------------------------------------------------------


        ///5. Employee Data
        EmployeeData employeeData = new EmployeeData();

        //Employee Data Added
        employeeData.AddEmployee(new Employee(101, "puja", "IT"));
        employeeData.AddEmployee(new Employee(102, "asmita", "Testing"));
        employeeData.AddEmployee(new Employee(103, "Disha", "Devops"));

        //Display Employee Data
        employeeData.DisplayEmp();
        Console.WriteLine();

        //Search Employee
        Employee emp = employeeData.SearchById(102);
        if (emp != null)
            emp.Display();
        else Console.WriteLine("Employee not found!");

        Console.WriteLine();

        // remove Employee
        employeeData.RemoveEmployee(101);
        Console.WriteLine();

        //Display Employee Data
        employeeData.DisplayEmp();

    }


}