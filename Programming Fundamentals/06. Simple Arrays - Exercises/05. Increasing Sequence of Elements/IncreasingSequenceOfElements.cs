namespace _05.Increasing_Sequence_of_Elements
{
    using System;
    using System.Linq;

    class IncreasingSequenceOfElements
    {
        static void Main(string[] args)
        {
            var stringArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isIncreasing = true;
            int previous = stringArray[0];
            for (int i = 1; i < stringArray.Length; i++)
            {
                if (stringArray[i] < previous)
                {
                    isIncreasing = false;
                    break;
                }

                previous = stringArray[i];
            }

            if (isIncreasing)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
