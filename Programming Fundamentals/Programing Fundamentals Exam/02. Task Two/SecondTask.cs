namespace SecondTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SecondTask
    {
        public static void Main()
        {


            while (true)
            {
                var inputLine = Console.ReadLine();

                if (inputLine == "Worm Ipsum")
                {
                    break;
                }
                var sentences = inputLine.Split(
                    new[] { '.' }, StringSplitOptions.RemoveEmptyEntries);

                if (sentences.Length != 1)
                {
                    continue;
                }

                var sentence = sentences[0];

                var words = sentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var replacedWord = string.Empty;
                char repeatedLettr = 'a';
                foreach (var word in words)
                {
                    var firstRepeatedLetter = word.GroupBy(x => x).OrderByDescending(x => x.Count()).First().Key;
                    var count = 0;
                    for (int i = 0; i < word.Length; i++)
                    {

                        if (word[i] == firstRepeatedLetter)
                        {
                            count++;
                            if (count > 1)
                            {
                                for (int j = 0; j < word.Length; j++)
                                {
                                    replacedWord = word.Replace(word[j], firstRepeatedLetter);
                                }
                                repeatedLettr = firstRepeatedLetter;
                                break;
                            }


                        }

                    }
                }

                foreach (var word in words)
                {

                    if (word == replacedWord)
                    {
                        sentence = sentence.Replace(word, new string(repeatedLettr, word.Length));
                    }
                }

                if (!sentences.Contains(sentence))
                {
                    Console.WriteLine(sentence);

                }

            }

        }
    }
}
