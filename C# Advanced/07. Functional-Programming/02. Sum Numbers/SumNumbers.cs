using System;
using System.Linq;

internal class SumNumbers
{
    private static void Main()
    {
        var numbers = Console.ReadLine();

        Func<string, int> parser = n => int.Parse(n);
        Console.WriteLine(numbers.Split(new string[] { ", " },
                          StringSplitOptions.RemoveEmptyEntries)
                                 .Select(parser)
                                 .Count());

        Console.WriteLine(numbers.Split(new string[] { ", " },
                          StringSplitOptions.RemoveEmptyEntries)
                                 .Select(parser)
                                 .Sum());

    }
}