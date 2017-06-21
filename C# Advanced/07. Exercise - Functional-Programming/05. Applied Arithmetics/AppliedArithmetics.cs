using System;
using System.Collections.Generic;
using System.Linq;

internal class AppliedArithmetics
{
    private static void Main()
    {
        List<int> nums = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        string command = Console.ReadLine().ToLower();

        while (command != "end")
        {
            switch (command)
            {
                case "add": nums = nums.Select(n => n + 1).ToList(); break;
                case "multiply": nums = nums.Select(n => n * 2).ToList(); break;
                case "subtract": nums = nums.Select(n => n - 1).ToList(); break;
                case "print": Console.WriteLine(string.Join(" ", nums)); break;
                default:
                    break;
            }

            command = Console.ReadLine();
        }
    }
}