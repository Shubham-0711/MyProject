using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.LOOP
{
    internal class whilesum1to10
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 10;

            while (i >= 1)
            {
                sum += i;
                i--;


            }
            Console.WriteLine(sum);
        }
    }
}
