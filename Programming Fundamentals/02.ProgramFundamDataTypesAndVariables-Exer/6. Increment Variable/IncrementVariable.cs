//Write a program to increment a byte variable(starting at 0) n times and print the result.
//If you detect an overflow (or several), print how many times there was an overflow alongside the variable value.Sounds simple, right?

using System;

class IncrementVariable
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());
        if (number < 256)
        {
            Console.WriteLine(number);
        }
        else
        {
            Console.WriteLine(number % 256);
            Console.WriteLine($"Overflowed {number / 256} times");
        }

    }
}