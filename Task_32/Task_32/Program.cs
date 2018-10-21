using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_32
{
    class Program
    {
        static double Sequence(int n)
        {
            double divide = 1;
            double result = 1;
            for (int i = 1; i <= n; i++)
            {
                divide = divide / i;
                result = result + divide;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Sequence(n));
            Console.ReadKey();

        }
    }
}
