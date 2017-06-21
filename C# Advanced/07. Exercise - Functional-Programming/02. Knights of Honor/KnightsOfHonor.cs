using System;
using System.Collections.Generic;
using System.Linq;

internal class KnightsOfHonor
{
    private static void Main()
    {
        List<string> names = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

        Action<string> print = name => Console.WriteLine("Sir " + name);

        foreach (var name in names)
        {
            print(name);
        }
    }
}