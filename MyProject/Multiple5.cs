using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class Multiple5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No ");
            int n = int.Parse(Console.ReadLine());

            if (n % 5 == 0)
            {
                Console.WriteLine("Number Is Multiple Of 5");
            }
            else
            {
                Console.WriteLine("Number Is Not Multiple Of 5");
            }

        }
       
    }
}
