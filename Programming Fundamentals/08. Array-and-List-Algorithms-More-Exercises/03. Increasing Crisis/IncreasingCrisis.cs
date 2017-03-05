namespace IncreasingCrisis
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class IncreasingCrisis
    {
        public static void Main()
        {
            var countLines = int.Parse(Console.ReadLine());
            var line = Console.ReadLine().Split().Select(int.Parse).ToList();
            var currentIndex = 0;

            for (int i = 0; i < countLines - 1; i++)
            {
                var nextline = Console.ReadLine().Split().Select(int.Parse).ToList();
                var firstElement = nextline[0];

                for (int j = 0; j < nextline.Count - 1; j++)
                {
                    if (nextline[j] < nextline[j + 1])
                    {
                        InsertLine(line, nextline, firstElement);
                    }
                    if (nextline[j] > nextline[j + 1])
                    {
                        RemoveLineToEnd(line, i);

                    }
                }
            }

            Console.WriteLine(string.Join(" ", line));
        }

        private static void RemoveLineToEnd(List<int> line, int i)
        {
            for (int h = i + 1; h < line.Count; h++)
            {
                line.RemoveAt(h);
                return;
            }
        }

        private static void InsertLine(List<int> line, List<int> nextline, int firstElement)
        {
            for (int j = line.Count - 1; j >= 0; j--)
            {
                if (line[j] < firstElement)
                {
                    line.InsertRange(j + 1, nextline);
                    return;
                }
            }
        }
    }
}
