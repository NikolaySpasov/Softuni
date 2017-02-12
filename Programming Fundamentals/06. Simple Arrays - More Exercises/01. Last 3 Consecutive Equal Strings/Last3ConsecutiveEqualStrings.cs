namespace _01.Last_3_Consecutive_Equal_Strings
{
    using System;

    class Last3ConsecutiveEqualStrings
    {
        static void Main()
        {
            var stringArr = Console.ReadLine().Split(' ');

            for (int i = stringArr.Length - 1; i >= 0; i--)
            {
                if (stringArr[i] == stringArr[i - 1] && stringArr[i - 1] == stringArr[i - 2])
                {
                    Console.WriteLine($"{stringArr[i]} {stringArr[i - 1]} {stringArr[i - 2]}");
                    break;
                }
            }
        }
    }
}
