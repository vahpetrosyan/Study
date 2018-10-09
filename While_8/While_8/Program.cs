using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 5;
            int B = 11;
            int N = A + 1;
            while (N < B)
            {
                int result = N % 3;
                if(result == 0)
                {
                Console.WriteLine(N);
                    break;
                }
                N++;
            }
            Console.ReadKey();

        }
    }
}
