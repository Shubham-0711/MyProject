using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
    /*Write a program to check whether a year is leap year or not*/
{
    internal class LEAPYR
    {
        static void Main(string[] args)
        {
            Console.WriteLine( "Enter Year :");
            int Year = Convert.ToInt32(Console.ReadLine());

            if ( Year%4 == 0&&Year%100!=0 )
            {
                Console.WriteLine("Leap Year :");
            }
            else
            {
                Console.WriteLine( "Non Leap Year :" );
            }



        }
    }
}
