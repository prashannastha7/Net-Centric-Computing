using System;

namespace Day_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------example of superclass constructor---------\n");
            Solution s1 = new Solution();
            Solution s2 = new Solution(5, 6, 7);
            s2.sum();
            s2.Square();
            Console.WriteLine("\n\n----------------------------\n\n");


            Console.WriteLine("\n------  example on method overriding  ------\n");
            Soln sol1 = new Soln();
            sol1.calc1();
            sol1.calc2(234, 42);
            Console.WriteLine("\n\n----------------------------\n\n");



            Console.WriteLine("\n---- ExceptionDemo ------\n");
            ExceptionDemo ed = new ExceptionDemo();
            ed.setData();


            Console.WriteLine("\n---- Custom Exception ----\n");
            CustomException ce = new CustomException();
            // jata bata error aairacha tya try and catch
            ce.setAge(15);
            ce.setAge(20);
            Console.ReadKey(); // to hold
        }
    }
}
