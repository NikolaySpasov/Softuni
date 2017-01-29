//Write a program that checks whether a number is a real number or an integer number.
//If the number is an integer, just print the number.If the number is a real number, print the closest integer to it.

using System;


class FloatOrInteger
{
    static void Main()
    {
        var number = double.Parse(Console.ReadLine());
        if ((number % 10) == 0)
        {
            Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine(Math.Round(number));
        }
    }
}

