﻿namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class WordCount
    {
        public static void Main()
        {
            string[] words = File.ReadAllText("words.txt").ToLower().Split();
            string[] text = File.ReadAllText("input.txt").ToLower()
                     .Split(new char[] { '\n', '\r', ' ', '.', ',', '!', '?', '-' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
                wordCount[word] = 0;

            foreach (string word in text)
                if (wordCount.ContainsKey(word))
                    wordCount[word]++;

        }
    }
}
