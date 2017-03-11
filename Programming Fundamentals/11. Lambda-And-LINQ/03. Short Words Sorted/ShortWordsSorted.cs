﻿namespace ShortWordsSorted
{
    using System;
    using System.Linq;

    public class ShortWordsSorted
    {
        public static void Main()
        {
            var separators = new char[] {'.',',',':',';','(',')','[',']','\\','\"','\'','/','!','?',' '};
            string sentence = Console.ReadLine().ToLower();
            string[] words = sentence.Split(separators);
            var result = words
              .Where(w => w != "")
              .Where(w => w.Length < 5)
              .OrderBy(w => w)
              .Distinct();
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
