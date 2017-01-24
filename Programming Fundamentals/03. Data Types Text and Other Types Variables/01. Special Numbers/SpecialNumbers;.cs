using System;

class SpecialNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            var currentNumber = i;
            var sum = 0;

            foreach (var symbol in currentNumber.ToString())
            {
                var digit = symbol - '0';
                sum += digit;
            }

            var result = sum == 5 || sum == 7 || sum == 11;

            Console.WriteLine("{0} -> {1}", i, result);

            //Console.WriteLine($"{i} -> {result}");
        }
    }
}