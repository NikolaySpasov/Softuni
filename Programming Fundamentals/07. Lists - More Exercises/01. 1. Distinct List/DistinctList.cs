namespace DistinctList
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class DistinctList
    {
        static void Main()
        {
            var line = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < line.Count; i++)
            {
                for (int j = i + 1; j < line.Count; j++)
                {
                    if (line[i] == line[j])
                    {
                        line.RemoveAt(j);
                        j--;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", line));
        }
    }
}