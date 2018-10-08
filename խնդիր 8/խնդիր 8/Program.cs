using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace խնդիր_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 3;
            int B = 8;
            for(int i = A+1 ; i < B; i++)
            {
                int firstResult = i % 3;
                if(firstResult ==0)
                {
                    break;
                }
                Console.WriteLine(i);

            }

            Console.ReadKey();
        }
    }
}
