using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MyProject
{
    internal class greaterthan5
    {
        static void Main(string[] args)
        {

            Console.WriteLine( "Enter NO = ");
            int a = Convert.ToInt32(Console.ReadLine());
            if (a > 5)
            {
                Console.WriteLine("NO. is greater than 5 :" + a);
            }
            else
            {
                Console.WriteLine("NO. is smaller than 5 :" + a);

            }

        }
    }
}
