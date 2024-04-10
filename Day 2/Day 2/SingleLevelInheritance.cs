using System;

namespace Day_2
{
    class Employee
    {
        private int id;
        private string name;
        private string address;
        private string department;
        //method to initialize instance variable

        public void setEmployee(int id, string name, string address, string department)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.department = department;
        }
        public void displayEmployee()
        {
            Console.WriteLine(" id is " + this.id);
            Console.WriteLine(" name is " + this.name);
            Console.WriteLine(" address is " + this.address);
            Console.WriteLine(" department is " + this.department);
        }
    }
    //inheritance Employee by teacher
    class Teacher : Employee //teacher is sub class , Employee is super class
    {
        private string specialization;
        private string salary;

        public void setTeacher(string specialization, string sal)
        {
            this.specialization = specialization;
            salary = sal; // variable name different then no use of this.        
        }
        public void displayTeacher()
        {
            Console.WriteLine("Specialization is " + this.specialization);
            Console.WriteLine("salary is " + salary);
        }
    }
}
