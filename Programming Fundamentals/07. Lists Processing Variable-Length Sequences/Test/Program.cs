namespace Template
{
    using System;

    class Program
    {
        static void Main()
        {
            string phrase = "The quick  brown fox";
            string[] words;

            words = phrase.Split(default(string[]), StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < words.Length; i++)
            {
                Console.Write(words[i]);
            }
            Console.WriteLine();

            words = phrase.Split((string[])null, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in words)
            {
                Console.Write(item);
            }

            Console.WriteLine();
            words = phrase.Split(null as string[], StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(string.Join(" ",words));
        }
    }
}
