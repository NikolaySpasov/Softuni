namespace Ladybugs
{
    using System;
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

            for (int i = 0; i < ladybugIndexes.Length; i++)
            {
                var currentLadybugIndex = ladybugIndexes[i];
                ladybugs[currentLadybugIndex] = 1;
            }

            var Line = Console.ReadLine();
            while (Line != "end")
            {
                var tokens = Line.Split();

                var ladybugIndex = int.Parse(tokens[0]);
                var direction = tokens[1];
                var flyLength = int.Parse(tokens[2]);

                if (ladybugIndex < 0 || ladybugIndex >= ladybugs.Length)
                {
                    Line = Console.ReadLine();
                    continue;
                }

                if (ladybugs[ladybugIndex] == 0)
                {
                    Line = Console.ReadLine();
                    continue;
                }

                MoveLadybug(ladybugs, ladybugIndex, flyLength, direction);
                Line = Console.ReadLine();

            }

            Console.WriteLine(string.Join(" ", ladybugs));

        }

        static void MoveLadybug(int[] ladybugs, int ladybugIndex, int flyLength, string direction)
        {
            ladybugs[ladybugIndex] = 0;
            var leftArrayOrFoundPlace = false;

            while (!leftArrayOrFoundPlace)
            {
                switch (direction)
                {
                    case "left":
                        ladybugIndex -= flyLength;
                        break;
                    case "right":
                        ladybugIndex += flyLength;
                        break;
                }

                if (ladybugIndex < 0 || ladybugIndex >= ladybugs.Length)
                {
                    leftArrayOrFoundPlace = true;
                    continue;
                }

                if (ladybugs[ladybugIndex] == 1)
                {
                    continue;
                }

                if (ladybugs[ladybugIndex] == 0)
                {
                    ladybugs[ladybugIndex] = 1;
                    leftArrayOrFoundPlace = true;
                    continue;
                }
            }
            
        }
    }
}