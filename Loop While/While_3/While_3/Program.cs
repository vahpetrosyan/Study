using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int degree = 1;
            while (degree < 10)
            {
                double result = Math.Pow(N, degree);
                Console.WriteLine(result);
                degree++;
            }
            Console.ReadKey();
        }
    }
}
