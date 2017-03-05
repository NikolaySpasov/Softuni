namespace DictRef
{
    using System;
    using System.Collections.Generic;

    public class DictRef
    {
        public static void Main()
        {
            var result = new Dictionary<string, int>();
            var line = Console.ReadLine();

            while (line != "end")
            {
                var tokens = line.Split();
                var firstElement = tokens[0];
                var lastElement = tokens[tokens.Length - 1];
                int number = 0;
                if (int.TryParse(lastElement, out number))
                {
                    result[firstElement] = number;
                }
                else
                {
                    if (result.ContainsKey(lastElement))
                    {
                        var referencedValue = result[lastElement];
                        result[firstElement] = referencedValue;

                    }
                }
                line = Console.ReadLine();
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} === {kvp.Value}");
            }
        }
    }
}
