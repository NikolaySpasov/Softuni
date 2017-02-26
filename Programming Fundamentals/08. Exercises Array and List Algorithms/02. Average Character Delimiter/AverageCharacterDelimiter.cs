namespace AverageCharacterDelimiter
{
    using System;
    using System.Linq;

    public class AverageCharacterDelimiter
    {
        public static void Main()
        {
            var stringArray = Console.ReadLine().Split().ToArray();

            int sum = 0;
            int count = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                char[] characters = stringArray[i].ToCharArray();
                foreach (var character in characters)
                {
                    sum += (int)character;
                    count++;
                }
            }

            char delimiterChar = (char)(sum / count);
            var delimiter = Char.ToUpper(delimiterChar);
            string del = string.Empty + delimiter;
            Console.WriteLine(string.Join(del,stringArray));
        }
    }
}