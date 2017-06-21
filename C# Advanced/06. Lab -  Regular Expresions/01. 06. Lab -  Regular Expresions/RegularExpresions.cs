using System;
using System.Linq;
using System.Text.RegularExpressions;

public class MatchCount
{
    public static void Main()
    {
        string pattern = Console.ReadLine().Trim();
        string text = Console.ReadLine();

        Regex regex = new Regex(pattern);

        MatchCollection matches = regex.Matches(text);

        int count = matches.Count;

        Console.WriteLine(count);
    }
}
