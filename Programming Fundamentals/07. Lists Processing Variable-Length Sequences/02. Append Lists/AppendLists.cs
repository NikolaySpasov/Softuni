namespace AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AppendLists
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries).ToList();
            var result = new List<string>();

            for (int i = numbers.Count - 1; i >=  0; i--)
            {
                result.Add(numbers[i]);

            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
