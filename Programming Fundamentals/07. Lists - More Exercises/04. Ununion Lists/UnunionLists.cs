namespace UnunionLists
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class UnunionLists
    {
        public static void Main()
        {
            var primalList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var lines = Console.ReadLine().Split().Select(int.Parse).ToList();

                RemoveElements(primalList, lines);
                AddElement(primalList, lines);
            }

            primalList.Sort();
            Console.WriteLine(string.Join(" ",primalList));
        }

        private static void AddElement(List<int> primalList, List<int> lines)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                primalList.Add(lines[i]);
            }
        }

        private static void RemoveElements(List<int> primalList, List<int> lines)
        {
            var tempList = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < primalList.Count; i++)
            {
                for (int j = 0; j < lines.Count; j++)
                {
                    if (primalList[i] == lines[j])
                    {
                        primalList.Remove(primalList[i]);
                        lines.Remove(lines[j]);
                        j = 0;
                        i = 0;
                    }
                }
            }
        }
    }
}
