using System;
using System.Globalization;
 
class SinoTheWalker
{
    static void Main()
    {
        var timeFormat = @"hh\:mm\:ss";
        var leavingTime = TimeSpan.ParseExact(Console.ReadLine(), timeFormat, CultureInfo.InvariantCulture);
        var stepsNeeded = decimal.Parse(Console.ReadLine());
        var secondsPerStep = decimal.Parse(Console.ReadLine());
        const int  secondsInADay = 60 * 60 * 24;
        var totalSecondNeeded = (int)(stepsNeeded * secondsPerStep % secondsInADay);
        var arrivalTime = leavingTime.Add(new TimeSpan(0,0,totalSecondNeeded));

        Console.WriteLine($"Time Arrival: " + arrivalTime.ToString(timeFormat));
    }
}