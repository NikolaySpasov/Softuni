using System;

namespace _01.Multiply_Evens_by_Odds
{
    public class MultiplyEvensByOdds
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvenAndOdds(num));
        }

        private static int GetMultipleOfEvenAndOdds(int num)
        {
            int sumEvens = GetSumEvensDigits(num);
            int sumOdds = GetSumOddsDigits(num);

            return sumEvens * sumOdds;
        }

        private static int GetSumOddsDigits(int num)
        {
            var sum = 0;
            num = Math.Abs(num);
            while (num > 0)
            {
                var currentDigit = num % 10;
                if (currentDigit % 2 != 0)
                    sum += currentDigit;

                num /= 10;
            }

            return sum;
        }

        private static int GetSumEvensDigits(int num)
        {
            var sum = 0;
            num = Math.Abs(num);
            while (num > 0)
            {
                var currentDigit = num % 10;
                if (currentDigit % 2 == 0)
                    sum += currentDigit;

                num /= 10;
            }

            return sum;
        }
    }
}