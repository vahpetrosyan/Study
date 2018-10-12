using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace խնդիր_22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            int sum = 1;
            void divisorsSum()
            {
                for (i = 1; i <= n; i++)
                {
                    int result = n % i;
                    if(result == 0)
                    {
                      int res=   (sum+= i)-1;
                        Console.WriteLine(res);
                    }
                }
            }
            divisorsSum();
            Console.ReadKey();
        }
    }
}
