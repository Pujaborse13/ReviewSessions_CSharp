using ReviewSession_5;

namespace NUnitTestProject
{
    public class Tests
    {
     // 5.Use NUnit to write unit tests for a simple calculator class that performs addition, subtraction, multiplication, and division.

        private CalculatorOperations co;

        [SetUp]
        public void Setup()
        {
            co = new CalculatorOperations();
        }

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






    }
}