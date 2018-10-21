using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_29
{
    class Program
    {

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 100; i <=999; i++)
            {
                    if (i == i % 100 * 7)
                    {
                        Console.WriteLine(i);
                    }
            }
            Console.ReadKey();
            
        }
    }
}
