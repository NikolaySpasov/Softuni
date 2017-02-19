namespace Template
{
    using System;

    class SplitByWordCasing
    {
        static void Main()
        {
            char[] separator = { ',', ';', ':', '.', '!', '(', ')', '"', '\'', '\\', '/', '[', ']', ' ' };
            string input = Console.ReadLine().Split(separator).ToString();

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write(input[2]);
            }


        }
    }
}
