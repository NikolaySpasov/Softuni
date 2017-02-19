namespace TearListInHalf
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class TearListInHalf
    {
        public static void Main()
        {
            var integerList = Console.ReadLine().Split().Select(int.Parse).ToList();

            var result = new List<int>();

            for (int i = 0; i < integerList.Count / 2; i++)
            {
                result.Add(FirstDigit(integerList[(integerList.Count / 2) + i]));
                result.Add(integerList[i]);
                result.Add(SecondDigit(integerList[(integerList.Count / 2) + i]));
            }

            Console.WriteLine(string.Join(" ", result));
        }

        public static int FirstDigit(int number)
        {
            return number / 10;
        }

        public static int SecondDigit(int number)
        {
            return number % 10;
        }
    }
}
