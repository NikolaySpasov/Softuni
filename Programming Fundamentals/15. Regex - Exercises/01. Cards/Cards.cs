namespace Cards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Cards
    {
        public static void Main()
        {
            string inputCards = Console.ReadLine();
            List<string> validCards = new List<string>();

            string pattern = @"([1]?[0-9JQKA])([SDHC])";
            Regex regex = new Regex(pattern);
            MatchCollection matchedCards = regex.Matches(inputCards);

            foreach (Match card in matchedCards)
            {
                int power = 0;
                if (int.TryParse(card.Groups[1].Value,out power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }
                validCards.Add(card.Value);
            }

            Console.WriteLine(string.Join(", ", validCards));
        }
    }
}
