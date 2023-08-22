using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
/*    Write a program to enter marks of five subjects and calculate total, average and percentage
*/

    internal class Percentage
    {
        static void Main(string[] args)
        {
            int Phy, Chem, Maths, Total; /*Declearation of variables*/
            double per;

            Console.WriteLine("Enter The Marks Of Subjects ="); /*getting value from user*/
            Phy = Convert.ToInt32(Console.ReadLine());
            Chem = Convert.ToInt32(Console.ReadLine()); /*Initialization of variables*/
            Maths = Convert.ToInt32(Console.ReadLine());

            Total =Phy + Chem + Maths; /*Total stores the add.of marks*/
            Console.WriteLine(Total);

            per = Total / 3; /*per devide total marks n div 3*/
            Console.WriteLine(per); /*Print the percentage*/

/*
            lader elseif*/
            if (per>80)
            {
                Console.WriteLine("Grade A");
            }
            else if(per>70)
            {
                Console.WriteLine("Grade B");
            }
            else if(per>60)
            {
                Console.WriteLine("Grade C");
            }
            else 
            {
                Console.WriteLine("Grade D");
            }

        }
    }
}
