//Write program to enter a real number of terabytes and convert it to bits.

using System;
using System.Numerics;

class FromTerabytesToBits
{
    static void Main()
    {
        long oneTerabyte = 1024L*1024*1024*1024*8;
        decimal number = decimal.Parse(Console.ReadLine());
        long result = (long)Math.Ceiling( number * oneTerabyte);
        Console.WriteLine(result);
    }
}

