using System;
using System.Collections.Generic;
using System.Linq;

internal class PredicateForNames
{
    private static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        List<string> names = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

        names = names.Where(x => x.Length <= n).ToList();

        Console.WriteLine(string.Join("\n", names));
    }
}