
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace խնդիր_է
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int j = 1; j < N; j++)
            {
                sum += j;
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}