using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MyProject
{
    internal class Test
    {
        static void Main(string[] args)
        {/*
            Console.WriteLine("Enter Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Welcome" + Name);

            int a = 10;
            int b = 3;
            Console.WriteLine("ADD = " + (a + b));
            Console.WriteLine("SUB = " + (a - b));
            Console.WriteLine("DIV = " + (a % b));
            Console.WriteLine("MULT = " + (a * b));*/

            Console.WriteLine("Enter Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Welcome ");
            Console.WriteLine("Enter The NO 1 = ");
           
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter The NO 2 = ");
            int b = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("ADD = " + (a + b));
            Console.WriteLine("SUB = " + (a - b));
            Console.WriteLine("DIV = " + (a % b));
            Console.WriteLine("MULT = " + (a * b));


        }

        private static void readline()
        {
            throw new NotImplementedException();
        }
    }
}
