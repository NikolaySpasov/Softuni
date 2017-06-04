using System;
using System.Collections.Generic;

class SoftUniParty
{
    static void Main()
    {
        var vip = new HashSet<string>();
        var regular = new SortedSet<string>();
        while (true)
        {
            var input = Console.ReadLine();
            if (input == "PARTY")
            {
                break;
            }

            if (IsVIP(input))
            {
                vip.Add(input);
            }
            else
            {
                regular.Add(input);
            }
        }
        while (true)
        {
            var input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }
            if (IsVIP(input))
            {
                vip.Remove(input);
            }
            else
            {
                regular.Remove(input);
            }
        }
        regular.UnionWith(vip);
        Console.WriteLine(regular.Count);
        foreach (var kvp in regular)
        {
            Console.WriteLine(kvp);
        }
    }

    private static bool IsVIP(string input)
    {
        var firstSymbol = input[0];
        int digit;
        var isDigit = int.TryParse(firstSymbol.ToString(), out digit);
        return isDigit;
    }
}