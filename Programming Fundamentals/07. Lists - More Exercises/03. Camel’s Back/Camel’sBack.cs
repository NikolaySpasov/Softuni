namespace CamelBack
{
    using System;
    using System.Linq;

    public class CamelBack
    {
        public static void Main()
        {
            var buildings = Console.ReadLine().Split().Select(int.Parse).ToList();
            var camelBackSize = int.Parse(Console.ReadLine());

            var rounds = 0;
            if (buildings.Count > camelBackSize)
            {
                do
                {
                    int index = 0;
                    buildings.RemoveAt(index);
                    buildings.RemoveAt(buildings.Count - 1 - index);
                    index++;
                    rounds++;
                }
                while (buildings.Count > camelBackSize);

                Console.WriteLine($"{rounds} rounds");
                Console.WriteLine($"remaining: {string.Join(" ", buildings)}");
            }
            else
            {
                Console.WriteLine($"already stable: {string.Join(" ", buildings)}");
            }
        }
    }
}