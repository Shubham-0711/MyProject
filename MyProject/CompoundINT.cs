using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject  /*Write a program to enter P, T, R and calculate Compound Interest.*/
    /*
P = principal amount
r = rate of interest
t = time(in years)
    ci=comppounnd interest
    */
    
{
    internal class CompoundINT 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principal Amount :" );
            int P=Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("Enter Time Period : ");
            int T=Convert.ToInt32( Console.ReadLine() );

            Console.WriteLine("Enter Rate :");
            int R=Convert.ToInt32( Console.ReadLine() );
            double CI = 0;

            CI = P * (1 + R / 100) ^ T;
            Console.WriteLine("Compound Inteest Is =" + CI);


        }
    }
}
