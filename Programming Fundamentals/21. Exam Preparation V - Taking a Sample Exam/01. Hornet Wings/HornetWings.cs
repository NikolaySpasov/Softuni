using System;

namespace HornetWings
{
    class HornetWings
    {
        static void Main(string[] args)
        {
            var wingFlaps = long.Parse(Console.ReadLine());
            var distancePerThousandWingFlaps = double.Parse(Console.ReadLine());
            var endurance = long.Parse(Console.ReadLine());

            var totalDistance = (wingFlaps / 1000) * distancePerThousandWingFlaps;

            var movingTime = wingFlaps / 100;
            var restTime = (wingFlaps / endurance) * 5;

            Console.WriteLine($"{totalDistance:F2} m.");
            Console.WriteLine($"{movingTime + restTime} s.");
        }
    }
}
