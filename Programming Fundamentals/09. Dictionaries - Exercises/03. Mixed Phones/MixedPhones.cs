namespace MixedPhones
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class MixedPhones
    {
        public static void Main()
        {
            var result = new SortedDictionary<string, decimal>();
            var line = Console.ReadLine();

            while (line != "Over")
            {
                var tokens = line.Split(" :".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                var firstElement = tokens[0];
                var secondElement = tokens[1];

                decimal phoneNumber = 0;

                if (decimal.TryParse(firstElement, out phoneNumber))
                {
                    result[secondElement] = phoneNumber;
                }
                else if (decimal.TryParse(secondElement, out phoneNumber))
                {
                    result[firstElement] = phoneNumber;
                }

                line = Console.ReadLine();
            }


            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
