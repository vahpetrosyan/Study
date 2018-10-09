using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_12
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            int b = 1;
            while (b <= 2*N-1)
            {
                result += b;
                Console.WriteLine(result);
                Console.WriteLine("------------------");
                b += 2;
            }
            Console.ReadKey();
        }
    }
}
