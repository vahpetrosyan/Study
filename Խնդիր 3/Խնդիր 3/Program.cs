using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Խնդիր_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                if (i < a)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
