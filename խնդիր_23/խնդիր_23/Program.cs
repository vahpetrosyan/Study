﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace խնդիր_23
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            int sum = 1;
                    int res = 0;
                    int count = 0;
            void divisorsOperations()
            {
                for (i = 1; i <= n; i++)
                {
                    int result = n % i;
                    if (result == 0)
                    {
                       res = (sum += i) - 1;
                        count++;
                        
                    }
                }
                    int finalResult = res / count;
                    Console.WriteLine(finalResult);
            }
            divisorsOperations();
            Console.ReadKey();
        }
    }
}
