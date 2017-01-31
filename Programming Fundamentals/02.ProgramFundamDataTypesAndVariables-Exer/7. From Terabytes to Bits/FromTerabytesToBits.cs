//Write program to enter a real number of terabytes and convert it to bits.

using System;
using System.Numerics;

class FromTerabytesToBits
{
    static void Main()
    {
        long oneTerabyte = 8796093022208;
        double number = double.Parse(Console.ReadLine());
        BigInteger result = (BigInteger)Math.Ceiling((double)number * oneTerabyte);
        Console.WriteLine(result);
    }
}

