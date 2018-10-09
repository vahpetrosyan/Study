using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_11
{
    class Program
    {
        static void Main(string[] args)
        {
            uint N = Convert.ToUInt32(Console.ReadLine());
            double result = 1;
            int B = 0;
            while (B <= N)
            {
                result *= 1 + (double)B / 10;
                Console.WriteLine("-------------------");
            Console.WriteLine(result);
                B++;
            }
            Console.ReadKey();
            
        }
    }
}
