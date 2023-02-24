using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class SwapNo
    {
        public static void Swapping()
        {
            Console.WriteLine("Enter the number1");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number2");
            int number2 = Convert.ToInt32(Console.ReadLine());

            number1 = number1+number2;
            number2 = number1-number2;
            number1 = number1-number2;
            Console.WriteLine("Numbers after swapping number1= " + number1   +  " number2 = "  + number2);

            //Suppose a=5 b=10
            //a + b =5+10=15
            //a-b=15-10=5
            //a-b=15-5=10
        }
    }
}

