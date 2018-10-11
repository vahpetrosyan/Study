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
            int i = 1;
            double result = 0;
            while (i <= N)
            {
                result += Math.Pow(-1, i - 1) * (1 + 0.1 * i);
                i++;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
