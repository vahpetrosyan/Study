using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = 8;
            int N = 12;
            int B = 0;
            while (B < N)
            {
                Console.WriteLine(K);
                B++;
            }
            Console.ReadKey();
        }
    }
}
