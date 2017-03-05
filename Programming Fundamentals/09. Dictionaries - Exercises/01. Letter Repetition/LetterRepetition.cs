namespace LetterRepetition
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class LetterRepetition
    {
        public static void Main()
        {
            var inputString = Console.ReadLine();
            var result = new Dictionary<char, int>();

            foreach (var letter in inputString)
            {
                if (!result.ContainsKey(letter))
                {
                    result[letter] = 0;
                }

                result[letter]++;
            }

            foreach (var kvp in result)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
