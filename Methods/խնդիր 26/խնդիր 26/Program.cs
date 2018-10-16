using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace խնդիր_26
{
    class Program
    {
        static void degree()
        {
            double n = Convert.ToInt32(Console.ReadLine());
            for (double i = 0; i < n; i++)
            {
                double result = Math.Pow(2, i);
                if(result>n && Math.Pow(2, i - 1) <= n)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            degree();
            Console.ReadKey();
        }
    }
}
