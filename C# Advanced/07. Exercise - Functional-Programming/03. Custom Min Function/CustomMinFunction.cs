using System;
using System.Collections.Generic;
using System.Linq;

internal class CustomMinFunction
{
    private static void Main()
    {
        List<int> numbers = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        Func<List<int>, int> minNumber = n => n.Min();

        Console.WriteLine(minNumber(numbers));
    }
}