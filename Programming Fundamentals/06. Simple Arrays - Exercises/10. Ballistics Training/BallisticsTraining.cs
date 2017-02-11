namespace BallisticsTraining
{
    using System;
    using System.Linq;

    public class BallisticsTraining
    {
        public static void Main()
        {
            string[] targetXandY = Console.ReadLine().Split().ToArray();
            string[] stringArray = Console.ReadLine().Split().ToArray();

            int targetX = int.Parse(targetXandY[0]);
            int targetY = int.Parse(targetXandY[1]);
            int x = 0;
            int y = 0;


            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i] == "right")
                {
                    x += int.Parse(stringArray[i + 1]);
                }
                else if (stringArray[i] == "left")
                {
                    x -= int.Parse(stringArray[i + 1]);
                }
                else if (stringArray[i] == "up")
                {
                    y += int.Parse(stringArray[i + 1]);
                }
                else if (stringArray[i] == "down")
                {
                    y -= int.Parse(stringArray[i + 1]);
                }
            }

            Console.WriteLine($"firing at [{x}, {y}]");

            if (x == targetX && y == targetY)
            {
                Console.WriteLine("got 'em!");
            }
            else
            {
                Console.WriteLine("better luck next time...");
            }
        }
    }
}