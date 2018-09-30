using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            long firstVariable;
            long secondVariable;
            long operation;


            Console.WriteLine("Please enter first nubmer");
            firstVariable = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Please enter second number");
            secondVariable = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Please enter arithmetical operation number");
            Console.WriteLine("----------------------------");
            Console.WriteLine("2-for addition");
            Console.WriteLine("----------------------------");
            Console.WriteLine("3-for substaction");
            Console.WriteLine("----------------------------");
            Console.WriteLine("4-for division");
            Console.WriteLine("----------------------------");
            Console.WriteLine("5-for multiplication");
            Console.WriteLine("----------------------------");
            Console.WriteLine("6-for percentage");
            Console.WriteLine("----------------------------");
            Console.WriteLine("7-for square root of first number");
            Console.WriteLine("----------------------------");
            Console.WriteLine("8-for exponentation");
            Console.WriteLine("----------------------------");

            operation = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
        


            if (operation == 2 && firstVariable + secondVariable >= 0)
            {
                long result = firstVariable + secondVariable;
                Console.WriteLine($"Your result is {result}");
                
                Console.ReadKey();
            }
            else if (operation == 3 && firstVariable - secondVariable >= 0)
            {
                long result = firstVariable - secondVariable;
                Console.WriteLine($"Your result is {result}");
                
                Console.ReadKey();
            }
            else if (operation == 4 && secondVariable != 0  && firstVariable / secondVariable >= 0)
            {
                long result = firstVariable / secondVariable;
                Console.WriteLine($"Your result is {result}");
                
                Console.ReadLine();
            }
            else if (operation == 5 && firstVariable * secondVariable >= 0)
            {
                long result = firstVariable * secondVariable;
                Console.WriteLine($"Your result is {result}");
                
                Console.ReadLine();
            }
            else if (operation == 6 && firstVariable % secondVariable >= 0)
            {
                long result = firstVariable % secondVariable;
                Console.WriteLine($"Your result is {result}");
                
                Console.ReadLine();
            }
            else if (operation == 7 && Math.Sqrt(firstVariable) >= 0)
            {
                double result = Math.Sqrt(firstVariable);
                Console.WriteLine($"Your result is {result}");
                
                Console.ReadLine();
            }

           else if(operation == 8 && Math.Pow(firstVariable,secondVariable) >= 0)
            {
                double result = Math.Pow(firstVariable, secondVariable);
                Console.WriteLine($"Your result is {result}");
                
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your result is below zero!");
                Console.WriteLine("Please choose another nubmers!");
                Console.WriteLine("Press any key to star over");
                Console.ReadKey();
            }
            Console.ReadKey();
        }
    }
}
            
                
               
            