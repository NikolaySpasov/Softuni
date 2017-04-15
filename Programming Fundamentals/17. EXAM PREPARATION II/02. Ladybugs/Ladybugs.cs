namespace Ladybugs
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Ladybugs
    {
        public static void Main()
        {
            int filedSize = int.Parse(Console.ReadLine());
            var ladybugIndexes = Console.ReadLine()
                .Split().Select(int.Parse)
                .Where(a => a >= 0 && a < filedSize)
                .ToArray();

            var ladybugs = new int[filedSize];

            for (int i = 0; i < ladybugs.Length; i++)
            {
                var currentLadybugIndex = ladybugIndexes[i];
                ladybugs[currentLadybugIndex] = 1;
            }

        }
    }
}
