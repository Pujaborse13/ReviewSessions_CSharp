using ReviewSession1_Puja;

class Program
{
    static void Main(string[] args)
    {
        
        //Swap two number
        SwapInteger swapInteger = new SwapInteger();
        swapInteger.SwapTwoInteger();


        //Type Conversion
        TypeConversion typeConversion = new TypeConversion();
        typeConversion.TypeConversionImplicitAndExplicit();


        //Fibonnacci Series
        FibonacciSeries fibonacciSeries = new FibonacciSeries();
        fibonacciSeries.FibonacciSeriesUptoN();

       
        //Muliplication Table of given number
        MultiplicationTable multiplication = new MultiplicationTable();
        multiplication.MultiplicationTableofGivenNum();
         

        //Abstract Shape Class 
        Shape circle = new Circle(5);   //radius
        circle.DisplayInfo();
        Console.WriteLine("Area Of Circle : " + circle.CalculateArea());

        Shape rectagle = new Rectangle(2, 4); //length and breadth 
        rectagle.DisplayInfo();
        Console.WriteLine("Area of Rectangle :" + rectagle.CalculateArea());

        Shape triangle = new Triangle(2, 5); //breadth and height
        triangle.DisplayInfo();
        Console.WriteLine("Area of Triangle :" + triangle.CalculateArea());

    }

}