using System;


namespace Day_1
{
    class Rectangle //class name can be any
    {
        //properties is used to initialize instance variable and return value of it
        //same as setter and getter method. Constructor return this don't return
        private int length;
        private int breadth;

        //using properties
        public int Length
        {
            get { return length; }
            set { this.length = value; }
        }

        public int Breadth
        {
            get { return breadth; }
            set { this.breadth = value; }
        }
    }
}
