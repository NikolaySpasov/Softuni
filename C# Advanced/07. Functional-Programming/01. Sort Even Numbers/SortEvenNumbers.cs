using System;
using System.Linq;


class SortEvenNumbers
{
    static void Main()
    {
        Console.WriteLine(string.Join(", ",Console.ReadLine()
            .Split(new string [] { "," },StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .Where(x => x %2 ==0)
            .OrderBy(x => x)));
    }
}

