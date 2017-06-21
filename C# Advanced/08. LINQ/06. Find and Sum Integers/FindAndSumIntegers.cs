using System;
using System.Linq;

internal class FindAndSumIntegers
{
    private static void Main()
    {
        var input = Console.ReadLine();
        var numbers = input.Split(' ')
            .Select(n =>
        {
            long value;
            bool success = long.TryParse(n, out value);
            return new { value, success };
        })
        .Where(b => b.success)
        .Select(x => x.value)
        .ToList();
        if (numbers.Count == 0)
        {
            Console.WriteLine("No match");
        }
        if (numbers.Count != 0)
        {
            Console.WriteLine(numbers.Sum());
        }
    }
}