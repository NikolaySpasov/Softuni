using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

internal class Program
{
    private static void Main()
    {
        var inputLine = Console.ReadLine();
        var indexes = new List<int>();
        var stack = new Stack<int>();
        var listForMatch = string.Empty;
        for (int i = 0; i < inputLine.Length; i++)
        {
            if (inputLine[i] == '[')
            {
                stack.Push(i);
            }
            else if (inputLine[i] == ']')
            {
                int startIndex = stack.Pop();
                string stringToMatch = inputLine.Substring(startIndex, i - startIndex + 1);
                listForMatch += listForMatch;
            }
        }
        MatchCollection matches = Regex.Matches(listForMatch, @"\[\S+<(\d+)REGEH(\d+)>\S+]");


        foreach (Match match in matches)
        {
            indexes.Add(int.Parse(match.Groups[1].Value));
            indexes.Add(int.Parse(match.Groups[2].Value));
        }

        var sb = new StringBuilder();
        var count = 1;

        for (int i = 0; i < indexes.Count; i++)
        {
            if (indexes[i] <= inputLine.Length)
            {
                if (indexes[i] != indexes[indexes.Count - 1])
                {
                    sb.Append((char)inputLine[indexes[i]]);
                    indexes[i + 1] += indexes[i];
                }
                else if (indexes[i] == indexes[indexes.Count - 1])
                {
                    if (indexes[indexes.Count - 1] == inputLine.Length)
                    {
                        sb.Append((char)inputLine[2]);
                        break;
                    }
                    sb.Append((char)inputLine[indexes[i]]);
                }


            }
            if (indexes[i] > inputLine.Length)
            {
                sb.Append((char)inputLine[indexes[i] % (inputLine.Length) + count]);
                count++;
            }

        }
        Console.WriteLine(sb);
    }
}