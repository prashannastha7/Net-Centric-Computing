using System;

//Exception is any kind of error that disturb the normal flow of program,
//if exception occur then whole program is stopped to deal with error exception 
//handling mechanism is required 

//it contains 4 keyword
//1.try: use to surround a code that can cause error
//2.catch: use to handle a exception thrown from try
//3.throw: use to throw own exception
//4.finally: this block is always executed


namespace Day_3
{
    class ExceptionDemo
    {
        public void setData()
        {
            Console.WriteLine("enter the first number: ");
            int x = Int32.Parse(Console.ReadLine()); //to convert into interger
            Console.WriteLine("enter the second number: ");
            int y = Int32.Parse(Console.ReadLine()); //to convert into interger
            try
            {
                int div = x / y;
                Console.WriteLine("div is " + div);
            }
            catch (DivideByZeroException d)
            {
                Console.WriteLine("Cannot divide " + d);
            }
            catch (Exception e) //it catch all the error, uses in last 
            {
                Console.WriteLine(e);
            }
            finally
            {
                Console.WriteLine("always excecuted");
            }
            Console.WriteLine("out of try catch");
        }
    }
}
