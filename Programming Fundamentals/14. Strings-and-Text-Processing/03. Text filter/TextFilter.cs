namespace TextFilter
{
    using System;
    using System.Linq;

    public class TextFilter
    {
        public static void Main()
        {
            var banWords = Console.ReadLine().Split(new[] { ',', ' '},StringSplitOptions.RemoveEmptyEntries);

            string text = Console.ReadLine();
            foreach (var word in banWords)
            {
                    text = text.Replace(word, new string('*', word.Length));
            }
            Console.WriteLine(text);

        }
    }
}
