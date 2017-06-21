using System;
using System.Linq;

internal class TakeTwo
{
    private static void Main()
    {
        Console.ReadLine()
      .Split(' ')
      .Select(int.Parse)
      .Where(n => n >= 10 && n <= 20)
      .Distinct()
      .Take(2)
      .ToList()
      .ForEach(n => Console.Write(n + " "));
    }
}