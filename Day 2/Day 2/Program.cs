using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("---  Example on single level inheritance  ----");
            //creating obj of sub class
            Teacher t1 = new Teacher();
            //using parent properties
            t1.setEmployee(1, "hari", "ktm", "IT");
            t1.displayEmployee();
            //using own properties
            t1.setTeacher("Networking", "50000");
            t1.displayTeacher();
            //creating obj of parent class (super class)
            Employee e1 = new Employee();
            e1.setEmployee(2, "sam", "pkr", "Management");
            e1.displayEmployee();
            //Employee cann't access to Teacher properties


            Console.WriteLine("\n\n----------------------------\n\n");

            Console.WriteLine("----  MultilevelInhertance  ----");
                //creating obj of grandchild (ElectricBike)
                ElectricBike eb = new ElectricBike();
            eb.Reg = 101; //value diyo set called huncha
            eb.Name = "niu";
            eb.Model = "new";
            //using parent property (Bike)
            eb.Speed = "40";
            //using own property
            eb.Range = "50";
            Console.WriteLine("reg is " + eb.Reg); //get called
            Console.WriteLine("name is " + eb.Name); //get called
            Console.WriteLine("model is " + eb.Model); //get called
            Console.WriteLine("speed is " + eb.Speed); //get called
            Console.WriteLine("range is " + eb.Range); //get called

            //creating object of Bike
            Bike bi = new Bike();
            //using TwoWheeler property
            bi.Reg = 102;
            bi.Name = "pulsar";
            bi.Model = "old";
            bi.Speed = "200"; //own property
            //bi.Range = "40"; cannot access
            Console.WriteLine("reg is bike " + bi.Reg);
            Console.WriteLine("name of bike " + bi.Name);
            Console.WriteLine("model of bike " + bi.Model);
            Console.WriteLine("speed of bike " + bi.Speed);

            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
