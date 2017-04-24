using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

class HappinessIndex
{
    static void Main()
    {
        var happyPattern = @"(:\)|:D|;\)|:\*|:\]|;\]|:}|;}|\(:|\*:|c:|\[:|\[;)";
        var sadPattern = @"(:\(|D:|;\(|:\[|;\[|:{|;{|\):|:c|\]:|\];)";

        var happyRegex = new Regex(happyPattern);
        var sadRegex = new Regex(sadPattern);

        var input = Console.ReadLine();

        var happyMatches = happyRegex.Matches(input);
        var sadMatches = sadRegex.Matches(input);

        decimal happyCount = happyMatches.Count;
        decimal sadCount = sadMatches.Count;

        decimal difference = happyCount / sadCount;

        var emoticon = string.Empty;

        if (difference >= 2)
        {
            emoticon = ":D";
        }
        else if (difference > 1)
        {
            emoticon = ":)";
        }
        else if (difference == 1)
        {
            emoticon = ":|";
        }
        else if (difference < 1)
        {
            emoticon = ":(";
        }

        Console.WriteLine($"Happiness index: {difference:F2} {emoticon}");
        Console.WriteLine($"[Happy count: {happyMatches.Count}, Sad count: {sadMatches.Count}]");

    }
}