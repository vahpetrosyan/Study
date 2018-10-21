using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_33
{
    class Program
    {

        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            double N = 1;
            double X = 1;
            for (int i = 1; i <= n; i++)
            {
                N *= x / i;
                X += N;

            }
            Console.WriteLine(X);
            Console.ReadKey();
        }
    }
}
