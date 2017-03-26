namespace OddLines
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class OddLines
    {
        public static void Main()
        {
            string[] text = File.ReadAllLines("input.txt");

            for (int i = 1; i < text.Length; i += 2)
            {
                File.AppendAllText("output.txt", text[i] + Environment.NewLine);
            }

            //string[] text = File.ReadAllLines("input.txt");

            //File.WriteAllLines("output.txt",text.Where((line, index) => index % 2 == 1));

        }
    }
}
