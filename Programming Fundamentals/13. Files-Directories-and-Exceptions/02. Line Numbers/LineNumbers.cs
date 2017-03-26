namespace LineNumbers
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class LineNumbers
    {
        public static void Main()
        {
            string[] text = File.ReadAllLines("input.txt");
            Console.WriteLine(text.Length);

            //for (int i = 0; i < text.Length; i++)
            //{
            //    File.AppendAllText("output.txt", $"{i + 1}. {text[i]}{Environment.NewLine}");
            //}
        }
    }
}
