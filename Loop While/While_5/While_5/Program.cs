using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 12;
            int result = 0;
            int B = 0;
            while (B < A)
            {
                result += B;
                B += 2;
            }
                Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
