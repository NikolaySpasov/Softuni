using System;

namespace _05.Integer_to_Base
{
    class IntegerToBaseMethod
    {
        static void Main()
        {
            long number = int.Parse(Console.ReadLine());
            int toBase = int.Parse(Console.ReadLine());

            Console.WriteLine(IntegerToBase(number, toBase));

        }

        static string IntegerToBase(long number, int toBase)
        {

            string result = string.Empty;
            while (number > 0)
            {
                var remainder = number % toBase;
                result = remainder + result;
                number /= toBase;
            }

            return result;

        }
    }
}
