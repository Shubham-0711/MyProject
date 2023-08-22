using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class SINGLENDOUBLE
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The NO. :");
            int num=Convert.ToInt32(Console.ReadLine());
           
            if (num<10) 
            {
                Console.WriteLine("No Is Single Digit : ");

            }
            else
            {
                Console.WriteLine("No is double digit :");
            }


        }
    }
}
