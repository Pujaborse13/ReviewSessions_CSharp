// See https://aka.ms/new-console-template for more information

using ReviewSession_5;

class Program
{
    /*
    public static void Main(string[] args)
    {
        
        //1. Prime Number
        PrimeNumberChecker primeNumberChecker = new PrimeNumberChecker();
        primeNumberChecker.CheckPrimeNumber();

        //2. Sort Name List
        SortNames sortNames = new SortNames();
        sortNames.PrintSortedList();
       
        //3.Stack Operations

            StackDemo<int> intStack = new StackDemo<int>();
                intStack.Push(10);
                intStack.Push(20);
                intStack.Push(30);

                intStack.Display();
                Console.WriteLine($"Peek value : {intStack.Peek()}");

                intStack.Pop();
                intStack.Display();


        //4.Custom age Exception 
        CheckAge checkAge = new CheckAge();
        checkAge.ValidateAge();
    */

        //6.Tpl Operations

        static async Task Main()
        {
            TplDemo demo = new TplDemo();
            await demo.ThreeTask();
        }





    //}


}

