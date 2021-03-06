﻿namespace _MultiplyAnArrayOfDoubles
{
    using System;
    using System.Linq;

    public class MultiplyAnArrayOfDoubles
    {
        public static void Main()
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).
                Select(double.Parse).
                ToArray();

            var p = double.Parse(Console.ReadLine());
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= p;
            }

            Console.WriteLine(string.Join(" ",numbers));
        }
    }
}
