using System;

public class RefactorSpecialNumbers
{
    public static void Main()
    {
        int maxNumber = int.Parse(Console.ReadLine());
        for (int i = 1; i <= maxNumber; i++)
        {
            var currentNumber = i;
            int sum = 0;
            while (currentNumber > 0)
            {
                sum += currentNumber % 10;
                currentNumber = currentNumber / 10;
            }

            var result = (sum == 5) || (sum == 7) || (sum == 11);
            Console.WriteLine($"{i} -> {result}");
        }

    }
}