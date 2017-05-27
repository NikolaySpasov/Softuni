using System;
using System.Collections.Generic;
using System.Linq;


public class SetsOfElements
{
    public static void Main()
    {
        var sets = Console.ReadLine().Split().Select(int.Parse).ToArray();
        var numbersFirstSet = sets[0];
        var numbersSecondSet = sets[1];
        var firstSet = new HashSet<int>();
        var secondSet = new HashSet<int>();
        var result = new List<int>();

        for (int i = 0; i < numbersFirstSet; i++)
        {
            firstSet.Add(int.Parse(Console.ReadLine()));
        }

        for (int i = 0; i < numbersSecondSet; i++)
        {
            secondSet.Add(int.Parse(Console.ReadLine()));
        }

        result = firstSet.Where(i => secondSet.Contains(i)).ToList();
        Console.WriteLine(string.Join(" ",result));
    }
}
