using System;
using System.IO;
using System.Security.Cryptography; // for file handling
namespace Day_4
{
    class FileReadWrite
    {
        public void writeFile()
        {
            //to create a file for writing, StreamWriter is used 
            StreamWriter sw = new StreamWriter("A://abc.txt");
            Console.WriteLine("Enter text to insert");
            string data = Console.ReadLine();
            sw.WriteLine(data);
            sw.Flush();//clear buffer and write to stream
            sw.Close();
        }

        public void readFile()
        {
            StreamReader sr = new StreamReader("A://abc.txt");
            string data1 = sr.ReadLine();


            Console.WriteLine(data1);

            sr.Close();
        }
    }
}
