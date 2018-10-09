using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace խնդիր_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstValue = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < 10; i++)
            {
            double result = Math.Pow(firstValue, i);
            Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
