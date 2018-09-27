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
            string sex;
            int year;
            

            Console.WriteLine("Please type your name");
            name = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Please type your surname");
            surname = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("What year were you born");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Please type your weight in kg");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Clear();

            Console.WriteLine("Are you male or female?");

            sex = Console.ReadLine();

            Console.Clear();

            age = 2018 - year;

            if(weight <= 95)
            {
                Console.WriteLine($"{name} {surname} you're {age} years old and also you're a thin {sex} ");
            }
            else
            {
                Console.WriteLine($"{name} {surname} you're {age} years old and also you're a thick {sex} ");
            }
            Console.WriteLine("Have a good day :)");

            Console.ReadKey();

        }


        
    }
}