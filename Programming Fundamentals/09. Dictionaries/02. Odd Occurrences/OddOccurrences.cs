namespace OddOccurrences
{
    using System;
    using System.Collections.Generic;

    public class OddOccurrences
    {
        public static void Main()
        {
            string input = Console.ReadLine().ToLower();
            string[] words = input.Split(new char[] {},StringSplitOptions.RemoveEmptyEntries);
            var counts = new Dictionary<string, int>();

            foreach (var word in words)

                if (counts.ContainsKey(word))
                {
                    counts[word]++;
                }
                else
                {
                    counts[word] = 1;
                }

            var results = new List<string>();

            foreach (var kvp in counts)
            {
                if ((kvp.Value % 2) != 0)
                {
                    results.Add(kvp.Key);
                }
            }

            Console.WriteLine(string.Join(", ", results));
        }
    }
}
