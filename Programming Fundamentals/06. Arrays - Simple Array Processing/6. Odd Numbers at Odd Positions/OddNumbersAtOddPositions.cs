namespace Odd_Numbers_at_Odd_Positions
{
    using System;
    using System.Linq;

    public class OddNumbersAtOddPositions
    {
        public static void Main()
        {
            var stringArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < stringArray.Length; i++)
            {
                if (i % 2 == 1 && Math.Abs(stringArray[i] % 2) == 1)
                {
                    Console.WriteLine($"Index {i} -> {stringArray[i]}");
                }
            }
        }
    }
}
