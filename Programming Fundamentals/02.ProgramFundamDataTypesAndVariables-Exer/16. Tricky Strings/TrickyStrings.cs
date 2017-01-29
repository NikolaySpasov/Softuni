//You are given a delimiter.On the next line, you will receive a number N.
//On the next N lines, you will receive strings on each line.Your task is to print the strings, separated by the delimiter.
//Note: the delimiter and strings could be anything: whitespace and empty strings are acceptable input!


using System;


class TrickyStrings
{
    static void Main()
    {
        string result = "";
        string delimiter = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n - 1; i++)
        {
            string strings = Console.ReadLine();
            result += ($"{strings}{delimiter}");
        }
        string lastString = Console.ReadLine();
        Console.WriteLine($"{result}{lastString}");
    }
}

