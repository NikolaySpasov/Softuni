using System;

namespace _04.Nth_Digit
{
    class NthDigit
    {
        static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            int indexN = int.Parse(Console.ReadLine());

            Console.WriteLine(FindNthDigit(number, indexN));

        }

        static int FindNthDigit(long number, int indexN)
        {
            int currentIndex = 1;
            long lastDigit = 0; ;

            while (number > 0)
            {
                lastDigit = number % 10;

                if (currentIndex == indexN)
                {
                    return (int)(number % 10);
                }

                currentIndex += 1;
                number /= 10;

            }

            return (int)(number % 10);
        }
    }
}
