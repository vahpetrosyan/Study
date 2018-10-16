using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace խնդիր_24
{
    class Program
    {

        static void Main(string[] args)
        {
            valueDegree();
            Console.ReadKey();
        }
        static void valueDegree()
        {
            double n = Convert.ToDouble(Console.ReadLine());
            for (double i = 2; i < n; i++)
            {
                double result = Math.Pow(n, 1.0 / i);
                if (result == 3)
                {
                    Console.WriteLine($"{n} is degree of 3");
                    break;
                }
            }
        }
    }
}
