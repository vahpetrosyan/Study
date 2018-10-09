using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 12;
            int result = 0;
            int B = 0;
            while (B < N)
            {
                result += B;
                B++;
            }
                Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
