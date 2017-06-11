using System;

class SpecialWords
{
    static void Main()
    {
        var wordSeparator = "()[]<>,-!? ".ToCharArray();
        var specialWords = Console.ReadLine().Split(wordSeparator, StringSplitOptions.RemoveEmptyEntries);
        var text = Console.ReadLine();

        int startIndex = 0;
        int count = 0;

        foreach (var word in specialWords)
        {
            while (true)
            {
                int found = text.IndexOf(word, startIndex);

                if (found >= 0)
                {
                    count++;
                    startIndex = found + 1;
                }
                else
                {
                    break;
                }

            }
            Console.WriteLine($"{word} - {count}");
            count = 0;
            startIndex = 0;
        }
    }
}
