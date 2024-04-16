using System;
using System.Collections.Generic; //list
using System.Linq;

//list stores collection of similar data. it uses generics so it can accept any type including object
//to use list<> symbol have to be used which indicare which type does list support 
namespace Day_4
{
    class ListDemo
    {
        public void setList()
        {
            List<int> l1 = new List<int> { 2, 3, 4, 5, 6, 10, 30 };
            //using predetermine method
            List<string> l2 = new List<string>();
            l2.Add("Ram");
            l2.Add("Hari");
            l2.Add("Raman");
            //foreach loop to display element
            foreach (var v in l1) //if data types is not sure write var, var = int,obj,string
            {
                Console.WriteLine(v);
            }
            //checking whether given character are present or not
            var res = l2.Contains("Hari");
            Console.WriteLine(res);
            //lamba expression: arrow function which doesn't have any type
            var res1 = l1.FindAll(x => (x % 2) == 0);
            foreach (var v in res1)
            {
                Console.WriteLine(v);
            }
            //finding out cube of each element using lambda expression
            var res2 = l1.Select(x => (x * x * x));
            foreach (var v in res2)
            {
                Console.WriteLine(v);
            }
        }
    }

    //list and lamda expression in user-defined class
    class Teacher
    {
        private int tid;
        private string tname;
        private string department;
        public int Tid
        {
            get { return tid; }
            set { tid = value; }
        }

        public string Tname
        {
            get { return tname; }
            set { tname = value; }
        }

        public string Department
        {
            get { return department; }
            set { department = value; }
        }
    }
}
