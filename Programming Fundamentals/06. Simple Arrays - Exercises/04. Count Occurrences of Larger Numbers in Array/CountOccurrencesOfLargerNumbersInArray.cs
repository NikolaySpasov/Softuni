namespace _04.Count_Occurrences_of_Larger_Numbers_in_Array
{
    using System;
    using System.Linq;

    class CountOccurrencesOfLargerNumbersInArray
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries).
                Select(double.Parse).
                ToArray();

            var p = double.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > p)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
