using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace խնդիր_21
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            {

                void findDivisors()
                {
                    for (int i = 1; i <= n; i++)
                    {
                        int result = n % i;
                        
                        if (result == 0)
                        {
                            Console.WriteLine(i);
                        }
                    }
                      
                }
                findDivisors();
                Console.ReadKey();

            }
}   }   }
