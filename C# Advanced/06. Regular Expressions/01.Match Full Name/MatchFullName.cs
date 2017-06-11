using System;
using System.Text.RegularExpressions;

public class MatchFullName
{
    public static void Main(string[] args)
    {
        string name = Console.ReadLine();

        string pattern = @"^[A-Z]{1}[a-z]+\s[A-Z][a-z]+";
        Regex regex = new Regex(pattern);

        while (name != "end")
        {
            Match match = regex.Match(name);
            Console.WriteLine(match.Value);

            name = Console.ReadLine();
        }
    }
}