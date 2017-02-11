namespace Altitude
{
    using System;
    using System.Linq;

    public class Altitude
    {
        public static void Main()
        {
            string[] arrayOfStrings = Console.ReadLine().Split().ToArray();
            double atitude = int.Parse(arrayOfStrings[0]);


            for (int i = 1; i < arrayOfStrings.Length; i++)
            {
                if (atitude <= 0)
                {
                    break;
                }

                if (arrayOfStrings[i] == "up")
                {
                    atitude += int.Parse(arrayOfStrings[i + 1]);
                }
                else if (arrayOfStrings[i] == "down")
                {
                    atitude -= int.Parse(arrayOfStrings[i + 1]);
                }
            }

            if (atitude <= 0)
            {
                Console.WriteLine("crashed");
            }
            else
            {
                Console.WriteLine($"got through safely. current altitude: {atitude}m");
            }
        }
    }
}
