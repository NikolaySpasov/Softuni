namespace SumAdjacentEqualNumbers
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    class SumAdjacentEqualNumbers
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var previousNumber = numbers[0];
            for (int i = 1; i < numbers.Count; i++)
            {
                if (previousNumber == numbers[i])
                {
                    numbers[i] += previousNumber;
                    numbers.Remove(previousNumber);
                    previousNumber = numbers[i];
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
