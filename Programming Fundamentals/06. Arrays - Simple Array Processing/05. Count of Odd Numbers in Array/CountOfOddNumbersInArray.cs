namespace Count_of_Odd_Numbers_in_Array
{
    using System;
    using System.Linq;

    public class CountOfOddNumbersInArray
    {
        public static void Main()
        {
            int[] intArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int count = 0;

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 != 0)
                {
                    count++;
                }
            }

                Console.WriteLine(count);
        }
    }
}
