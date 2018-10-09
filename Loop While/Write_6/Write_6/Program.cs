using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Write_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 8;
            int B = 14;
            int n = A + 1;
            while (n < B)
            {
                Console.WriteLine(n);
                Console.WriteLine("-----------------");
                n++;
            }
            int result = B - A;
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
