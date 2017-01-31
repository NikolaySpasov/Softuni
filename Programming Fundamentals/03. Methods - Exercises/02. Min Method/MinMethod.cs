using System;

namespace _02.Min_Method
{
    class MinMethod
    {
        static void Main()
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());

            int minNumber = GetMin(firstNumber, secondNumber);
            Console.WriteLine(GetMin(minNumber,thirdNumber));
        }

        private static int GetMin(int a, int b)
        {
            if (a <= b)
            {
                return a;
            }

            return b;
        }
    }
}
