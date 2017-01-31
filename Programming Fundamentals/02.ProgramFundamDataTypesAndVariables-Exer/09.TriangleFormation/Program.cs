using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int[] array = { a, b, c };
            array = array.OrderBy(number => number).ToArray();

            int sideA = array[0];
            int sideB = array[1];
            int sideC = array[2];

            int valid = 0;
            bool rightAngle = Math.Pow(sideA, 2) + Math.Pow(sideB, 2) == Math.Pow(sideC, 2);
            if ((a + b) > c)
            {
                if ((b + c) > a)
                {
                    if ((a + c) > b) //If a+b>c and a+c>b and b+c>a then it is valid  
                    {
                        valid = 1;
                    }
                }
            }

            if (valid == 1)
            {
                Console.WriteLine("Triangle is valid.");
                if (rightAngle)
                {
                    if (c > a && c > b)
                    {
                        Console.WriteLine("Triangle has a right angle between sides a and b");
                    }
                    else if (b > a && b > c)
                    {
                        Console.WriteLine("Triangle has a right angle between sides a and c");
                    }
                    else // a is the hypotenuse
                    {
                        Console.WriteLine("Triangle has a right angle between sides b and c");
                    }
                }
                else
                {
                    Console.WriteLine("Triangle has no right angles");
                }
            }
            else
            {
                Console.WriteLine("Invalid Triangle.");
            }
        }
    }
}