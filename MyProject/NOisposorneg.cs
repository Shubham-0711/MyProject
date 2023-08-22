using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    internal class NOisposorneg
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no. :");
            int a = Convert.ToInt32(Console.ReadLine());
          

            if (a == 0)
            {
                Console.WriteLine("NO is Zero : ");
            }
            else if (a >0) 
            {
                Console.WriteLine("NO is Positive  :");
            }
            else 
            {
                Console.WriteLine("NO is Negetive :");
            }

        }
    }
}
