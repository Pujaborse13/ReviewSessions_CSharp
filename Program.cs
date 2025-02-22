using System;
using System.ComponentModel.DataAnnotations;
using ReviewSession_3;

internal class Program
{
    private static void Main(string[] args)
    {
        //Q-1

        //1.1)Email Validation
        //1.2)Password Strength Checker
        //1.3)Phone Number Validator

        Console.Write("Enter an email address: ");
        string email = Console.ReadLine();

        
        Console.Write("Enter your Password ");
        string password = Console.ReadLine();

        Console.Write("Enter your Phone no ");
        string phoneNo= Console.ReadLine();


        var user = new ValidationDemo
        {

            Email = email,
            Password = password,
            PhoneNumber = phoneNo

        };
        var context = new ValidationContext(user);
        var results = new List<ValidationResult>();

        if (!Validator.TryValidateObject(user, context, results, true))
        {
            Console.WriteLine("Invalid deatils");
            foreach (var error in results)
            { 
                Console.WriteLine(error.ErrorMessage);

            }
        }
        else
        {
            Console.WriteLine("Valid details");
        }
       //-------------------------------------------------------

        //1.4 Find duplicates in sentence 

        DuplicateWord duplicate = new DuplicateWord();
        duplicate.FindDuplicate();

        //______________________________________________

        //Q.2 

        //2.1 Divison Number Exception
        BasicDivision basicDivision = new BasicDivision();
        basicDivision.DivisionNum();

        //2.2 AgeValidator
        AgeValidator ageValidator = new AgeValidator();
        ageValidator.ValidAge();

        //___________________________________________________

        //Q- 3
        //3.1.Bank System
        BankSystem bank = new BankSystem();
        Console.Write("Enter withdrawal amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());
        bank.Withdraw(amount);


        //3.2 Product Stock
        ProductStock product = new ProductStock();
        Console.Write("\nEnter quantity to purchase: ");
        int purchaseQuantity = Convert.ToInt32(Console.ReadLine());
        product.BuyProduct(purchaseQuantity);

        //------------------------------------------------------


        //Q-4

        //4. Using Lambda Expression

        UsingLambdaEx usingLambdaEx = new UsingLambdaEx();
        usingLambdaEx.EvenOdd();
       
       //Q-5).String Length Comparison
        usingLambdaEx.StringLengthCom();

        //Q-7.
        // 7.1 Number Transformation

        usingLambdaEx.NumberTransformation();

        //7.2 Find Maximum
        usingLambdaEx.MaxOfTwo();
      

    }
}