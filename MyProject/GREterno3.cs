using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyProject
     /*program to find maximum between three numbers */
{
    internal class GREterno3

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter NO1. =");
            int no1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter NO2. =");
            int no2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter NO3. =");
            int no3=Convert.ToInt32(Console.ReadLine());    

            if (no1 > no3) 
            {
                if(no1>no2)
                {
                    Console.WriteLine("NO 1 Is Greater :");
                }
                else
                {
                    Console.WriteLine("NO 2 Is Greater :");
                }
            }
            else if (no2 > no3)
            {
                if (no2 > no3)
                {
                    Console.WriteLine("NO 2 Is Greater  :");
                }
            }
            else
            {
                Console.WriteLine("NO 3 Is Greater  :");
            }
        }
    }
}
