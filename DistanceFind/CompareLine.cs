using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceFind
{
    internal class CompareLine
    {
        public void LenghtOfLine()
        {
            Console.WriteLine("Enter the cartesian coordinates of  (x1,y1)");
            double x1 = Convert.ToInt32(Console.ReadLine());
            double y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the cartesian coordinates of (x2,y2)");
            double x2 = Convert.ToInt32(Console.ReadLine());
            double y2 = Convert.ToInt32(Console.ReadLine());

            double Lenght1 = Math.Sqrt(Math.Pow(x2-x1, 2))+(Math.Pow(y2-y1, 2));

            Console.WriteLine("Enter the cartesian coordinates of  (x3,y3)");
            double x3 = Convert.ToInt32(Console.ReadLine());
            double y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the cartesian coordinates of (x4,y4)");
            double x4 = Convert.ToInt32(Console.ReadLine());
            double y4 = Convert.ToInt32(Console.ReadLine());

            double Lenght2 = Math.Sqrt(Math.Pow(x4-x3, 2)) + (Math.Pow(y4-y3, 2));
        
             Console.WriteLine("The lenght of the two points of line-1: " + Lenght1);
            Console.WriteLine("The lenght of the two points of line-2: " + Lenght2);
            if (Lenght1 < Lenght2)
            {
                Console.WriteLine("Line-1 is less than line-2");
            }
            else
            {
                if (Lenght2 < Lenght1)
                {
                    Console.WriteLine("Line-1 is Greater than line-2");
                }
                else
                {
                    Console.WriteLine("Line-1 is equal to line-2");
                }
            }


        }




    }

    }
