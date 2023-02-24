using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class Largest_No
    {
        public static void CheckLargestNo()
        {
            Console.WriteLine("Enter the Number1:");
            int number1=Convert.ToInt32(Console.ReadLine());    
            Console.WriteLine("Enter the Number2:");
            int number2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number3");
            int number3=Convert.ToInt32(Console.ReadLine());
            if (number1 > number2)
            {
                Console.WriteLine("number1 is greater than number2");
            }
            else if (number2 > number3)
            {
                Console.WriteLine("number2 is greater than number 3");
            }
            else 
            {
                Console.WriteLine("number 3 is greater than number1 and number2");
            }
        }
    }
}
