using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace խնդիր_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 8;
            int B = 16;
            for(int i =A+1 ;i<B; i++)
            {
                Console.WriteLine(i);
            }
            int value = B - A;
            Console.WriteLine(value);
            Console.ReadKey();
        }
    }
}
