using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class Power_of_2
    {
        public static void table()
        {
            int i, number;
            Console.WriteLine("Enter the number to print the table");
            number =Convert.ToInt32(Console.ReadLine());
            for (i = 1;i <= number;i++)
            {
                //number = number * i;
                Console.WriteLine(number * i);
            }
            Console.ReadLine();
        }
    }
}
