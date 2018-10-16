using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace խնդիր_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(valueMinOddDigit());
            Console.ReadKey();
        }
        static int valueMinOddDigit()
        {
          int num = Convert.ToInt32(Console.ReadLine());
            int digit = 11;
            while (num != 0)
            {
                int res = num % 10;
                if (res%2!=0 && res < digit)
                    digit = res;
                num /= 10;
            }
            return digit;
        }
        
        

       
    }
}