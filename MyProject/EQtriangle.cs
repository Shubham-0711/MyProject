using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    /*Write a program to calculate area of an equilateral triangle.*/
    internal class EQtriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Side ="); /*getting value from user*/
            int a=int.Parse(Console.ReadLine()); /*covert in int*/

            double c = 0;

            c = (1.5 / 4) * (a * a); /*formula of Equilateral Triangle*/

            Console.WriteLine("Area of Equilateral Triangle " +c  );
        }
    }
}
