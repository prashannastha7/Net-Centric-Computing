using System;

namespace Day_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object of box
            //when obj is created constructor is called.
            Box b1 = new Box(); //default constructor
            b1.calcArea();
            Box b2 = new Box(10, 25, 30);
            b2.calcArea();

            Console.WriteLine("\n\n----------------------------\n\n");

            //For PropertiesDemo
            Console.WriteLine("---PropertiesDemo---");
            Rectangle r1 = new Rectangle();

            //calling set of length and breadth
            r1.Length = 10;
            r1.Breadth = 20;

            //calling get of length & breadth
            Console.WriteLine("Length is " + r1.Length);
            Console.WriteLine("Breadth is " + r1.Breadth);

            int area = r1.Length * r1.Breadth;
            Console.WriteLine("Area is " + area);

            Console.WriteLine("\n\n----------------------------\n\n");

            Console.WriteLine("---- Example of method overloading ----");
            MethodOverloading c1 = new MethodOverloading();
            c1.calc();   //calling first method 
            c1.calc(12, 42);   //calling second method
            c1.calc(123.231, 24.21);        //calling third method
            int mul = c1.calc(12, 41, 11);   //calling fourth method
            Console.WriteLine("Multiplication is :" + mul);

            Console.ReadKey(); // to hold screen
        }
    }
}
