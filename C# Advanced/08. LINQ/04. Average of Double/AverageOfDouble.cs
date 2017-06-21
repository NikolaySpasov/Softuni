using System;
using System.Linq;

namespace _04.Average_of_Double
{
    internal class AverageOfDouble
    {
        private static void Main()
        {
            var average = Console.ReadLine()
                     .Split(' ')
                     .Select(double.Parse)
                     .Average();
            Console.WriteLine($"{average:f2}");
        }
    }
}