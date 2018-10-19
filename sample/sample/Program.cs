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
            int[] array = CreateRandomIntArray(10, 0, 100);

            Console.WriteLine("Original array");
            PrintArray(array);

            int[] sorted = SortArray(array, false);

            Console.WriteLine("Sorted array");
            PrintArray(sorted);

            Console.ReadKey();
        }
        static int[] CreateRandomIntArray(int n, int range1, int range2)
        {
            int[] array = new int[n];
            Random rd = new Random();
            for (int i = 0; i <= n; i++)
            {
                array[n] = rd.Next(range1, range2);

            }

            return array;
        }
        static void PrintArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }
        static void SortArray(int[] arr, bool flag)
        {

        }


    }

}
