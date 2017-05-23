namespace FirstTask
{
    using System;

    public class FirstTask
    {
        public static void Main()
        {
            var lengthInMeters = long.Parse(Console.ReadLine());
            var widthInCentimeters = double.Parse(Console.ReadLine());

            var length = lengthInMeters * 100;
            var result = length * widthInCentimeters;
            var reminder = length % widthInCentimeters;

            if (reminder == 0)
            {
                Console.WriteLine($"{result:F2}");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(100 * length) / widthInCentimeters:F2}%");
            }
        }
    }
}
