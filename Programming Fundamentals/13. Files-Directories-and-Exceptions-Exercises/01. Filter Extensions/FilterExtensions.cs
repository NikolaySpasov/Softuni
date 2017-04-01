namespace FilterExtensions
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class FilterExtensions
    {
        public static void Main()
        {
            string[] filesInDir = Directory.GetFiles("input");
            var result = new List<string>();

            for (int i = 0; i < filesInDir.Length; i++)
            {
                var fileExtension = filesInDir[i].Split('.').Last();
                if (fileExtension.Equals("txt"))
                {
                    result.Add(filesInDir[i]);
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
