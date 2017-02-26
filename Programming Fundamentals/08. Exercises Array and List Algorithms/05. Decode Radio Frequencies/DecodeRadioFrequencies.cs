namespace DecodeRadioFrequencies
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DecodeRadioFrequencies
    {
        public static void Main()
        {
            var radioFrequencies = Console.ReadLine().Split(' ').ToList();
            var result = new List<char>();

            for (int i = 0; i < radioFrequencies.Count; i++)
            {
                var separateDigits = radioFrequencies[i].ToString().Split('.').Select(int.Parse).ToList();

                int firstDigit = separateDigits[0];
                int secondDigit = separateDigits[1];

                if (firstDigit != 0)
                {
                    result.Insert(i, (char)firstDigit);
                }
                if (secondDigit != 0)
                {

                    result.Insert(result.Count - i, (char)secondDigit);
                }
            }
            Console.WriteLine(string.Join("", result));
        }
    }
}
