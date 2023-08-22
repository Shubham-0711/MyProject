using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MyProject
{
    internal class ANDorNOT
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Details :");
            int year=Convert.ToInt32(Console.ReadLine());
            int percentage = Convert.ToInt32(Console.ReadLine());

            if (year == 2021 && percentage==60) 
            {
                Console.WriteLine("User is valid");
            }
            else if(year == 2019 || percentage>90)
            {
                Console.WriteLine(  " VALID :");
            }
            else
            {
                Console.WriteLine("NOT VALID :");
            }
            

        }
    }
}
