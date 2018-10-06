using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace խնդիր_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 14;
            int finalValue = 0;
            for(int i = 0; i < A; i += 2)
            {
                finalValue += i;
            }
            Console.WriteLine(finalValue);
            Console.ReadKey();
        }
    }
}
