using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    internal class Albhabet
    {
        public static void Check()
        {
            Console.WriteLine("Enter the alphabet wheather it is vowel or consonant");
            char ch;
            ch=Convert.ToChar(Console.ReadLine());
            
                if(ch =='a'  || ch== 'e'  || ch== 'i' || ch=='o'|| ch=='u')
            {
                Console.WriteLine("alphabet is vowel");
            }
            else 
            {
                Console.WriteLine("alphabet is consonant");
            }
            

            Console.ReadLine();
        }
    }
    }

