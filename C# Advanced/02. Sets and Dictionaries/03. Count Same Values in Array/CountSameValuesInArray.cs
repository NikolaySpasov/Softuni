using System;
using System.Collections.Generic;
using System.Linq;

class CountSameValuesInArray
{
    static void Main()
    {
        var input = Console.ReadLine();
        var numbers = input.Split(new char[] { ' ' },
                            StringSplitOptions.RemoveEmptyEntries)
                           .Select(double.Parse).ToArray();
        var dictionary = new SortedDictionary<double, int>();
        foreach (var number in numbers)
        {
            if (!dictionary.ContainsKey(number))
                dictionary.Add(number, 1);
            else
                dictionary[number]++;
        }

        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key} - {kvp.Value} times");
        }
    }
}
