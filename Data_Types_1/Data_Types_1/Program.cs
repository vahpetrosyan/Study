using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            byte first_byte = 50;
            byte second_byte = 66;
            if (first_byte != 0)
            {
                int a = second_byte / first_byte;
                Console.WriteLine(a);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You can't divide by 0");
                Console.ReadKey();
            }
            Console.WriteLine("-----------------------");

            int first_int = 120;
            int second_int = 240;
            if (first_int != 0)
            {
                int int_result = second_int / first_int;
                Console.WriteLine(int_result);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You can't divide by 0");
                Console.ReadKey();
            }

            Console.WriteLine("-----------------------");

            short first_short = 2176;
            short second_short = 272;
            if (second_short != 0)
            {
                int short_result = first_short / second_short;
                Console.WriteLine(short_result);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You can't divide by 0");
                Console.ReadKey();
            }

            Console.WriteLine("-----------------------");

            long first_long = 65536;
            long second_long = 4096;
            if (second_long != 0)
            {
                long long_result = first_long / second_long;
                Console.WriteLine(long_result);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You can't divide by 0");
                Console.ReadKey();
            }
            Console.WriteLine("-----------------------");

            float first_float = 4.56f;
            float second_float = 2.44f;
            if (second_float != 0)
            {
                float float_result = first_float / second_float;
                Console.WriteLine(float_result);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You can't divide by 0");
                Console.ReadKey();
            }
            Console.WriteLine("-----------------------");

            double first_double = 1.46;
            double second_double = 0.48;
            if (second_double != 0)
            {
                double double_result = first_double / second_double;
                Console.WriteLine();
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You can't divide by 0");
                Console.ReadKey();
            }
            Console.WriteLine("-----------------------");
            decimal first_decimal = 614400;
            decimal second_decimal = 32768;
            if (second_decimal != 0)
            {
                decimal decimal_result = first_decimal / second_decimal;
                Console.WriteLine(decimal_result);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("You can't divide by 0");
                Console.ReadKey();
            }
            Console.ReadKey();
        }

    }
}
