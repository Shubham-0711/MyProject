using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class Compare
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No :");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            if (a == b && b == c)
            {
                Console.WriteLine("All no is similar :");

            }
            else
            {
                Console.WriteLine("Not similar...!");
            }

            /*Console.WriteLine("Enter NO. : ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());

            if (a == b) 
            {
                Console.WriteLine("NO. Is similar :");
            
            }
            else
            {
                Console.WriteLine("not Similar :");
            }*/
        }
    }
}
