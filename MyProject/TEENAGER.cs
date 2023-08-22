using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class TEENAGER
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Age  :");

            int A=Convert.ToInt32(Console.ReadLine());

            if (A>18) 
            {
                Console.WriteLine("ADULT... ");
            
            }
            else
            {
                Console.WriteLine(" TEENAGER ...");
            }
        }
    }
}
