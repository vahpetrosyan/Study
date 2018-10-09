using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_10
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N = Convert.ToUInt32(Console.ReadLine());
            double result = 0;
            int B = 0;
            while (B <= N)
            {
                result += Math.Pow(B + N, 2);
                B++;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
