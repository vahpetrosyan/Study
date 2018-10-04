using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometric_Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose geometric figure:\nType 1-for square\nType 2-for rectangle\nType 3-for circle");
            byte form = Convert.ToByte(Console.ReadLine());
            Console.Clear();
            if(form == 1)
            {
                Console.Write("A = ");


                int firstSide = Convert.ToInt32(Console.ReadLine());
                int result = firstSide * 4;
                Console.WriteLine(result);
                Console.ReadKey();

            }
            else if (form == 2)
            {
                Console.Write("A = ");
                int firstSide = Convert.ToInt32(Console.ReadLine());
                Console.Write("B = ");
                int secondSide = Convert.ToInt32(Console.ReadLine());
                int result = 2 * (firstSide + secondSide);
                Console.Write("The result is = ");
                Console.WriteLine(result);
                Console.ReadKey();
            }
            else if (form == 3)
            {
                Console.Write("R = ");
                double radius = Convert.ToDouble(Console.ReadLine());
                int area = Math.PI * (radius * radius);


            }

        }

       

}
}
