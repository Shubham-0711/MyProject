using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.LOOP
{
    internal class WhileODD1to20
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int i = 1;
          
            while(i<=20)
            {
                if (i % 2 != 0)
                {  
        
                    sum = sum + i;


                }
                i++;
            }
            Console.WriteLine(sum);
       


        }
    }
}
