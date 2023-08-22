using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MyProject
{
    internal class While_sumofdigit
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter No.  :");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;

            while (num > 0) 
            {
                int digit = num % 10;
                sum=sum+digit;
                num = num/10;
            }
            Console.WriteLine(sum);
        }
    }
}
