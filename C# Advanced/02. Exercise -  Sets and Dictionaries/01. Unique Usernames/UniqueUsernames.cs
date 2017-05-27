using System;
using System.Collections.Generic;

public class UniqueUsernames
{
    public static void Main()
    {
        var numberLines = int.Parse(Console.ReadLine());
        var userNames = new HashSet<string>();

        for (int i = 0; i < numberLines; i++)
        {
            userNames.Add(Console.ReadLine());
        }

        foreach (var userName in userNames)
        {
            Console.WriteLine(userName);
        }
    }
}