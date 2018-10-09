using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            int B = 0;
            if(N>=1 && N <= 9)
            {
                while (B < N)
                {
                    Console.WriteLine(B);
                    B++;
                }
            }
                else
                {
                    Console.WriteLine("Please enter value,that is lower 10 and above 0");
                }
                Console.ReadKey();
        }
    }
}
