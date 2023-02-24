using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class QuotiRemain
    {
        public static void CheckQuoRemain()
        {
            Console.WriteLine("Enter the number1");
            int no1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number2");
            int no2=Convert.ToInt32(Console.ReadLine());
            int quotient=no1/no2;
            Console.WriteLine("quotient is:"+quotient);
            int remainder = no1%no2;
            Console.WriteLine("Remainder is:"+remainder);
        }
    }
}
