using System;
using System.Linq;

internal class UpperStrings
{
    private static void Main()
    {
        Console.ReadLine()
            .Split(' ')
            .Select(w => w.ToUpper())
            .ToList()
            .ForEach(w => Console.Write(w + " "));
    }
}