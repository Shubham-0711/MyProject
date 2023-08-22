using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class SWitchpro
    {
        static void Main(string[] args)
        {

            Console.WriteLine("enter no1 =");
            int n1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter no2 =");
            int n2=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1.ADDI");
            Console.WriteLine("2.SUB");
            Console.WriteLine("3.MULTI");
            Console.WriteLine("4.DIV");
            Console.WriteLine("5.MOD");

            Console.WriteLine( "ENter Choice");
            int ch=Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.WriteLine("ADD of TWO No. ="+(n1+n2));
                    break;
                case 2:
                    Console.WriteLine("SUB of TWO No. =" + (n1 - n2));
                    break;
                case 3:
                    Console.WriteLine("MULTI of TWO No. =" + (n1 * n2));
                    break;
                case 4:
                    Console.WriteLine("DIV of TWO No. =" + (n1 / n2));
                    break;
                case 5:
                    Console.WriteLine("MOD of TWO No. =" + (n1 % n2));
                    break;

            }
        }
    }
}
