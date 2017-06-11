using System;
using System.Text.RegularExpressions;

class SeriesOfLetters
{

    static void Main()
    {
        var text = Console.ReadLine();

        Console.WriteLine(Regex.Replace(text, @"([a-z]{1})\1+","$1"));
    }
}