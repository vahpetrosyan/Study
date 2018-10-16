using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace խնդիր_19
{
    class Program
    {
        static int evenNumberFunc()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int b = 1;
            while (n != 0)
            {
                int s = n % 10;
                if (even(s) == true && s < 7)
                {
                    b = b * s;
                }
                else
                {
                    Console.WriteLine("Your number doesn't have any even number");
                }
                n /= 10;
            }
            return b;
        }
        static bool even(int n)
        {
         return  n % 2 == 0;
         
        }
        static void Main(string[] args)
        {
            Console.WriteLine(evenNumberFunc());
            Console.ReadKey();
        }
    }
}
