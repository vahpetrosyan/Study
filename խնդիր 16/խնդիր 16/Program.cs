using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace խնդիր_16
{
    class Program
    {

        static void sum()
        {
            int a = int.Parse(Console.ReadLine());

            int s = 0;
            while (a > 0)
            {

                s += a % 10;
                a = a / 10;

            }
            Console.WriteLine(s);
        }


        static void count()
        {

            int n = 52;
          double b =  Math.Ceiling(Math.Log10(n));
            Console.WriteLine(b);
        }
        static void multiplication()
        {
            int a = int.Parse(Console.ReadLine());

            int s = 1;
            while (a > 0)
            {

                s *= a % 10;
                a = a / 10;

            }
            Console.WriteLine(s);
        }


        static void Main(string[] args)
        {
            sum();
            count();
            multiplication();

            Console.ReadKey();


        }

    }
}
