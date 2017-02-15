namespace AppendLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class AppendLists
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split('|').ToList();
            var result = new List<string>();

            for (int i = numbers.Count - 1; i >=  0; i--)
            {
                //string current = numbers[i].Split(' ').Select(int.Parse);
                result.Add(numbers[i]);

            }

            Console.WriteLine(string.Join("", result));
        }
    }
}
