﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class EvenOddNumber
    {
        public  static void check_number()
        {
            Console.WriteLine("Enter the number to check wheather it is even or odd");
            int number=Convert.ToInt32(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            }
            else
            {
                Console.WriteLine("Number is odd");
            }
        }
    }
}
