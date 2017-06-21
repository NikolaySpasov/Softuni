using System;
using System.Collections.Generic;
using System.Linq;

internal class ActionPrint
{
    private static void Main(string[] args)
    {
        List<string> names = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).ToList();

        Action<string> print = name => Console.WriteLine(name);

        foreach (var name in names)
        {
            print(name);
        }
    }
}