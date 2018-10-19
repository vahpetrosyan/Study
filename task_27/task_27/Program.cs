using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_27
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] firstArray = new int[1];
            firstArray[0] = n;
            for (int i = 0; i <= n; i++)
            {
                int result = n % 10;
                n /= 10;
                result = result * 10;
                Console.Write(result);
            }
            Console.ReadKey();
        }
    }
}
