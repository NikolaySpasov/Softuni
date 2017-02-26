namespace Batteries
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Batteries
    {
        public static void Main()
        {
            var capacitiesOfBatteries = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var batteriesUsagePerHour = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var stressTest = int.Parse(Console.ReadLine());

            for (int i = 0; i < capacitiesOfBatteries.Length; i++)
            {
                var drainOfBattery = batteriesUsagePerHour[i] * stressTest;
                var restPowerAfterTest = capacitiesOfBatteries[i] - drainOfBattery;
                var capacityAfterTest = restPowerAfterTest / (capacitiesOfBatteries[i] / 100);

                if (capacityAfterTest < 0)
                {
                    var hoursBeforebatteryDead = Math.Ceiling(capacitiesOfBatteries[i] / batteriesUsagePerHour[i]);
                    Console.WriteLine($"Battery {i + 1}: dead (lasted {hoursBeforebatteryDead } hours)");
                }
                else
                {
                    Console.WriteLine($"Battery {i + 1}: {restPowerAfterTest:F2} mAh ({capacityAfterTest:F2})%");

                }
            }
        }
    }
}
