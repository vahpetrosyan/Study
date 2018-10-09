using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 4;
            int B = 9;
            int sum = 0;
            int n = A+1;
            while (n < B)
            {
                sum += n;
                n++;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
