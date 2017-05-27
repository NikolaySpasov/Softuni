using System;
using System.Collections.Generic;

public class CountSymbols
{
    public static void Main()
    {
        var text = Console.ReadLine();

        var result = new SortedDictionary<char, int>();

        for (int i = 0; i < text.Length; i++)
        {
            if (!result.ContainsKey(text[i]))
            {
                result.Add(text[i], 1);
            }
            else
            {
                result[text[i]]++;

            }
        }

        foreach (var kvp in result)
        {
            Console.WriteLine($"{kvp.Key}: {kvp.Value} time/s");
        }
    }
}
