using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReviewSession1_Puja
{

    abstract class Shape
    {
        public abstract double CalculateArea();

        public void DisplayInfo()
        {

            Console.WriteLine("Shape Class Info");
        }

    }

    class Circle : Shape

    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }


        public override double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

    }

    class Rectangle : Shape
    {
        private double length;
        private double breadth;

        public Rectangle(double length, double breadth)
        { 
            this.length = length;
            this.breadth = breadth;
        }

        public override double CalculateArea()
        {
            return length * breadth;

        }

    }


    class Triangle : Shape
    {
        private double b;
        private double h;

        public Triangle(double b, double h)
        { 
            this.b = b;
            this.h = h;
        }

        public override double CalculateArea()
        {

           {
                return (1.0 / 2) * b * h;

            }

        }

    }


}
