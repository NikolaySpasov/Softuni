using System;

public class CountSubstringOccurrences
{
    public static void Main(string[] args)
    {
        string text = Console.ReadLine().ToLower();
        string pattern = Console.ReadLine().ToLower();

        int startIndex = 0;
        int count = 0;

        while (true)
        {
            int found = text.IndexOf(pattern, startIndex);

            if (found >= 0)
            {
                count++;
                startIndex = found + 1;
            }
            else
            {
                break;
            }

        }

        Console.WriteLine(count);
    }
}
