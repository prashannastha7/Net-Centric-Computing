using System;

namespace Day_1
{
    class Box
    {
        //instance variable: class data
        private int length;
        private int breadth;
        private int height;


        //constructor:used to initialize instance variable
        //default constructor: w/o parameter
        public Box()
        {
            int length = 0;
            int breadth = 0;
            int height = 0;
        }

        //parameterized contructor
        public Box(int length, int breadth, int height)
        {
            this.length = length;
            this.breadth = breadth;
            this.height = height;
        }

        //method: used to provide some services
        //method -> w/o returing value
        public void calcArea()
        {
            int area = this.length * this.breadth * this.height;
            Console.WriteLine("Area is " + area);
        }
    }
}
