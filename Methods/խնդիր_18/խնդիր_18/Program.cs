using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace խնդիր_18
{
    class Program
    {
        static int oddNumberFunc()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int b = 0;
            while (n != 0)
            {
               int s = n % 10;
                if(s%2 != 0 && s > 4)
                {
                    b =b+ s;
                }
                n /= 10;
            }
            return b;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(oddNumberFunc());
            Console.ReadKey();
        }
    }
}
