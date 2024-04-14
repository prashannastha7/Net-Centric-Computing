﻿using System;

//to create own kind of exception:
//1. create a error class by inheriting superclass Exception and call the constructor
//with error message.
//2. use throw keyword to throw particular exception

namespace Day_3
{
    class AgeException : Exception
    {
        public AgeException(string msg) : base(msg) { }
    }
    class CustomException
    {
        public void setAge(int age)
        {
            try
            {
                if (age < 16)
                {
                    throw new AgeException("Age must be greater than 16.");
                }
                else
                {
                    Console.WriteLine("Age is: " + age);
                }
            }
            catch (AgeException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

