using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class Class2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No :");
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int c=Convert.ToInt32(Console.ReadLine());

            if (a == b && b==c) 
            {
                Console.WriteLine("All no is similar :");
            
            }
            else
            {
                Console.WriteLine("Not similar...!");
            }
        }
    }
}
