using Microsoft.VisualStudio.TestPlatform.TestHost;
using System.ComponentModel;
using ReviewSession_3;

namespace MyTestProject
{

    public class Tests
    {
        private CalculatorOperations co;
        private PalindromeString check;


        [SetUp]
        public void Setup()
        {
            co = new CalculatorOperations();
            check = new PalindromeString();
        }

        //Test Calculator Class
        //Write a Calculator class with methods for addition, subtraction, multiplication, and division.
        //Write NUnit tests to validate the correctness of these methods.
        
         [Test] 
        public void AdditionOfTwoNum()
        {
            int a = 10;
            int b = 20;
            int expectedSum = 30;

            var result = co.Addition(a, b);
            Assert.AreEqual(expectedSum, result);

        }
            [Test] 
            public void SubtractionOfTwoNum()
            {
                int a = 20, b = 10;
                int expected = 10;

                var result = co.Subtration(a, b);
                Assert.AreEqual(expected, result);
            }

        [Test] 
        public void MultiplicationOfTwoNum()
        {
            int a = 5, b = 4;
            int expected = 20;

            var result = co.Multiplication(a, b);
            Assert.AreEqual(expected, result);
        }


        [Test] 
        public void DivisionOfTwoNum()
        {
            int a = 20, b = 5;
            int expected = 4;

            var result = co.Division(a, b);
            Assert.AreEqual(expected, result);
        }


        [Test] 
        public void DivisionByZeroShouldThrowException()
        {
            int a = 10, b = 0;
            Assert.Throws<System.DivideByZeroException>(() => co.Division(a, b));
        }


        //_______________________________________________________
        //Palindrome Checker
        //Write a program that checks whether a string is a palindrome.
        //Write NUnit tests to:
        //Check valid palindromes (e.g., "madam").
        //Check invalid strings(e.g., "hello").


        [Test] 
        public void ValidPalindrome()
        {
            Assert.IsTrue(check.IsPalindrome("madam"));
            Assert.IsTrue(check.IsPalindrome("level"));
        }

        [Test] 
        public void Test_InvalidPalindrome()
        {
            Assert.IsFalse(check.IsPalindrome("hello"));
            Assert.IsFalse(check.IsPalindrome("world"));
        }




    }
}