using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        Regex regex = new Regex(@"((?<=\s)[a-zA-Z0-9]+([-.]\w*)*@[a-zA-Z]+?([.-][a-zA-Z]*)*(\.[a-z]{2,}))");

        MatchCollection matches = regex.Matches(input);

        foreach (Match item in matches)
        {
            Console.WriteLine(item.Value);
        }
    }
}
