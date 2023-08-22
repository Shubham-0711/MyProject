using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.LOOP
{
    internal class _10to1cal
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i=10;i>=1;i--) 
            {
                sum += i;
               
            }
            Console.WriteLine(sum);
        }
    }
}

