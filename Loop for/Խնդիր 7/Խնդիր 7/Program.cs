using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Խնդիր_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 4;
            int B = 12;
            int result = 0;
            for(int i = A+1; i < B; i++)
            {
                result += i;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
