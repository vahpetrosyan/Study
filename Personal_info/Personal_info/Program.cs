using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_info
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string surname;
            int age;
            double weight;
            string gender;
            int year;
            Console.ReadKey();

        }
        static string name()
        {
            Console.WriteLine("Enter your name");
            string myname = Console.ReadLine();
            return myname;

        }
    } 
}