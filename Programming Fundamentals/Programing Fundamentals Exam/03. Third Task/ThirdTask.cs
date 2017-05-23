namespace ThirdTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ThirdTask
    {
        public static void Main()
        {
            var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            var count = 0;
            var currentIndex = 0;
            var countDigits = 0;
            for (int i = 0; i < line.Count; i++)
            {
                if (line[i] == 0)
                {
                    count++;
                    continue;
                }
                if (line[i] != 0)
                {

                    count += line[i];

                }
            }
            Console.WriteLine(count);

        }
    }
}
