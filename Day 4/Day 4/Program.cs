using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----  FileDemo  -----");
            FileReadWrite fd = new FileReadWrite();
            fd.writeFile();
            fd.readFile();

            Console.WriteLine("\n\n----------------------------\n\n");
            Console.WriteLine("-------------Example on Array demo------------");
            ArrayDemo ad = new ArrayDemo();
            ad.setArray();


            Console.WriteLine("\n\n----------------------------\n\n");

            Console.WriteLine("-------------Lambda Expression demo----------------");
            LambdaExpressionDemo l1 = new LambdaExpressionDemo();
            l1.setExpression();

            //creating list of object and arranging in ascending
            //order by name
            List<Employees> em = new List<Employees>()
            {
                new Employees() {Id=1,Name="Ram",Department="IT"},
                new Employees() {Id=2,Name="Man",Department="CA"},
                new Employees() {Id=3,Name="Haro",Department="HR"},
            };
            var so1 = em.OrderBy(x => x.Name);
            foreach (var e in so1)
            {
                Console.WriteLine("Id is " + e.Id + " Name is " + e.Name);
            }

            Console.WriteLine("");
            Console.WriteLine("\n\n----------------------------\n\n");

            Console.WriteLine("----List and Lambda----");
            ListDemo ld1 = new ListDemo();
            ld1.setList(); //first question
            //for second part
            //creating 5 obj of Teachers class using list
            List<Teacher> lt1 = new List<Teacher>()
            {
                new Teacher(){Tid=1,Tname="ram",Department="IT"},
                new Teacher(){Tid=2,Tname="hari",Department="IT"},
                new Teacher(){Tid=3,Tname="shya",Department="mgmt"},
                new Teacher(){Tid=4,Tname="shayam",Department="Science"},
                new Teacher(){Tid=5,Tname="rita",Department="IT"},
        };
            //calling get
            foreach (var v in lt1)
            {
                Console.WriteLine("id is " + v.Tid);
                Console.WriteLine("name is " + v.Tname);
                Console.WriteLine("department is " + v.Department);
            }

            Console.WriteLine("");
            Console.WriteLine("----Exam Question---");

            //using lamda to sort object and display
            var sort1 = lt1.OrderBy(x => x.Tname); //lt1 bata name lai x le denote garacha teslai name bata sort garney aani sort1 ma rakhney
            foreach (var v in sort1)
            {
                Console.WriteLine("id is " + v.Tid);
                Console.WriteLine("name is " + v.Tname);
                Console.WriteLine("depart is " + v.Department);
            }

            Console.ReadKey(); //to hold screen
        }
    }
}
