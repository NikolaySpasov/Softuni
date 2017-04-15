namespace SinoTheWalker
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SinoTheWalker
    {
        public static void Main()
        {
            var duration = Console.ReadLine().Split(':').Select(int.Parse).ToArray();
            var timeDuration = new TimeSpan(duration[0], duration[1], duration[2]);
            var wolkingInSeconds = int.Parse(Console.ReadLine());
            var timePerStep = wolkingInSeconds *  int.Parse(Console.ReadLine());
            var stepsInSecond = new TimeSpan(00, 00, timePerStep);

            var result = timeDuration + stepsInSecond;

            Console.WriteLine($"Time Arrival: {result:\\:hh.ff\\:mm\\:ss}");

        }
    }
}
