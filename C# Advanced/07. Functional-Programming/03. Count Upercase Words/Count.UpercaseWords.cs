﻿using System;
using System.Linq;

internal class Program
{
    private static void Main()
    {
        var words = Console.ReadLine().Split(new string[] { " " },
                 StringSplitOptions.RemoveEmptyEntries);

        Func<string, bool> checker = n => n[0] == n.ToUpper()[0];

        words.Where(checker)
             .ToList()
             .ForEach(n => Console.WriteLine(n));
    }
}