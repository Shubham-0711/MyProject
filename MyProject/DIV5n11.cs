﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
/*    program to check whether a number is divisible by 5 and 11 or not*/

{
    internal class DIV5n11
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the NO. =");
            int A = Convert.ToInt32(Console.ReadLine());

            if (A%5 == 0) 
            {
                Console.WriteLine("NO is Divisible By 5 !");
            
            }
            else if(A%11==0)
            {
                Console.WriteLine("NO is Divisible By 11 !");
            }
            else
            {
                Console.WriteLine("NO is Not divisible!! ");
            }

        }
    }
}
