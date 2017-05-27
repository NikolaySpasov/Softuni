using System;
using System.Collections.Generic;
using System.Linq;

class PeriodicTable
{
    static void Main()
    {
        var number = int.Parse(Console.ReadLine());
        var elements = new HashSet<string>();

        for (int i = 0; i < number; i++)
        {
            var line = Console.ReadLine().Split();

            foreach (var element in line)
            {
                elements.Add(element);
            }
            //elements.UnionWith(line);
        }
        Console.WriteLine(string.Join(" ", elements.OrderBy(x => x)));
    }
}