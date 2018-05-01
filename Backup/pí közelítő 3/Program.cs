using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///double pi = 4 * (4 * Math.Atan2(1, 5) - Math.Atan2(1, 239)); // !!Machin-formula!! // gyors, sok tag


            double pi2 = Math.Pow(1, 1);// / 1; //Euler féle módszer // ugyszint gyors
            for (int i = 3; ; i += 2)
            {
                pi2 -=  Math.Pow(pi2, i) / i;
                pi2 = Math.Atan(pi2);
                i += 2;
                pi2 += Math.Pow(pi2, i) / i;
                pi2 = 4 * Math.Atan(pi2);
                Console.WriteLine(Math.Abs(pi2/2));
                Console.ReadKey();
            }

            //Console.WriteLine(pi);
            
        }
    }
}
