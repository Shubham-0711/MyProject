using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MyProject.LOOP
{
    internal class Do_while
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter no.");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(  "enter no2.");
            int num1=Convert.ToInt32(Console.ReadLine());
            char ch;

            do
            {
                Console.WriteLine("1.Add.");
                Console.WriteLine("2.Sub.");
                Console.WriteLine("3.Mul.");
                Console.WriteLine("4.Div");

                Console.WriteLine("Enter your Choice :");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine(num + num1);
                        break;
                    case 2:
                        Console.WriteLine(num - num1);
                        break;
                    case 3:
                        Console.WriteLine(num * num1);
                        break;
                    case 4:
                        Console.WriteLine(num % num1);
                        break;
                }
                Console.WriteLine("Do you want to continue...");
                ch = Convert.ToChar(Console.ReadLine());

            }   while(ch== 'Y'||ch=='y');       
                    
        }
    }
}
