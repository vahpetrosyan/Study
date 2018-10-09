using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace խնդիր_9
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i < input; i++)
            {
                int result = 1 + (1 / i);
                Console.WriteLine(result);
            }
            Console.ReadKey();
        }
    }
}
