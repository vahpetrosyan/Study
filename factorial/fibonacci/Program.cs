using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
       

        static void Main(string[] args)
        {
            Console.WriteLine(factorial(5));
            Console.ReadLine();

        }
        static int factorial(int n)
        {
            if (n <= 1)
                return 1;

            else
                return n *= factorial(n - 1);

        }
    }
}
