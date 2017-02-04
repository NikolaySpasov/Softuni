////Create a program that finds for how many weeks, days, hours, minutes and seconds can an object fly at light speed
////Assume that 1 light year == 9 450 000 000 000 km.
////Assume that the speed of light == 300 000 km / second.
////•On first line you receive – the light years to convert
////Every number in the output should be formatted to 0 digits after the floating point
////•On first line – time in weeks
////•On second line – time in days
////•On third line – time in hours
////•On fourth line – time in minutes
////•On fifth line – time in seconds

using System;
using System.Globalization;

public class TravelingAtLightSpeed
{
    public static void Main()
    {
        decimal inputLightYears = decimal.Parse(Console.ReadLine());

        decimal lightYear = 9450000000000M;
        decimal speedOfLight = 300000M;

        decimal seconds = inputLightYears * (lightYear / speedOfLight);

        TimeSpan diff = TimeSpan.FromSeconds((double)seconds);
        string formatted = string.Format(
              CultureInfo.CurrentCulture,
              "{0} weeks\n{1} days\n{2} hours\n{3} minutes\n{4} seconds\n",
              diff.Days / 7,
              diff.Days % 7,
              diff.Hours,
              diff.Minutes,
              diff.Seconds);

        Console.WriteLine(formatted);

        ////decimal weeks = (decimal)seconds / (7*1*24*60*60);
        ////decimal days = (decimal)(weeks %1);
        ////decimal days1 = (decimal) 7 * days*100;
        ////Console.WriteLine(days1);
        ////int hours = (int)seconds % 60;
        ////int minutes = (int)seconds % 60;
        ////Console.WriteLine($"{weeks} weeks");
        ////Console.WriteLine($"{days} days");
        ////Console.WriteLine($"{hours} hours");
        ////Console.WriteLine($"{minutes} minutes");
        ////Console.WriteLine($"{seconds} seconds");
    }
}