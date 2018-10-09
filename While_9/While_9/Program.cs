using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_9
{
    class Program
    {
        static void Main(string[] args)
        {
            uint A = Convert.ToUInt32(Console.ReadLine());
            int N = 1;
            double result = 0;
            while (N <= A)
            {
             result += 1 / (double)N;
             Console.WriteLine(result);
             Console.WriteLine("----------------");
             N++;
            }
            Console.ReadKey();
        }
    }
}
