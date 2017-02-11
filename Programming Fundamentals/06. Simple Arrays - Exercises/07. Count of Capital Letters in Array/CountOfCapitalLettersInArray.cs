namespace _07.Count_of_Capital_Letters_in_Array
{
    using System;
    using System.Linq;

    class CountOfCapitalLettersInArray
    {
        static void Main()
        {
            string[] arrayOfStrings = Console.ReadLine().Split().ToArray();

            int count = 0;
            for (int i = 0; i < arrayOfStrings.Length; i++)
            {
                string currentWord = arrayOfStrings[i];

                if (currentWord.Length == 1)
                {
                    char character = currentWord[0];

                    if (character >= 'A' && character <= 'Z')
                    {
                        count++;
                    }
                }

            }

            Console.WriteLine(count);
        }
    }
}
