using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Խնդիր_28
{
    class Program
    {
        static void  digitOperate()
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int result = 0;
            string[] answer = new string[2] { "yes", "no" };
            while (n>0)
            {
                result += n % 10;
                n /= 10;
            }
            if (n == result * 2)
            {
                Console.WriteLine(answer[0]);
            }
            else
            {
                Console.WriteLine(answer[1]);
            }
        }
        static void Main(string[] args)
        {
            digitOperate();
            Console.ReadKey();


        }
    }
}
