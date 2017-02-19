namespace EqualSumAfterExtraction
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class EqualSumAfterExtraction
    {
        public static void Main()
        {
            var firstList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var secondList = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var resultList = new List<int>();

            for (int i = 0; i < secondList.Count; i++)
            {
                resultList.Add(secondList[i]);
            }

            int firstListSum = 0;
            for (int i = 0; i < firstList.Count; i++)
            {
                firstListSum += firstList[i];
            }

            for (int i = 0; i < secondList.Count; i++)
            {
                for (int j = 0; j < firstList.Count; j++)
                {
                    if (secondList[i] == firstList[j])
                    {
                        resultList.Remove(secondList[i]);
                    }
                }
            }

            int resultListSum = 0;
            for (int i = 0; i < resultList.Count; i++)
            {
                resultListSum += resultList[i];
            }

            if (firstListSum == resultListSum)
            {
            Console.WriteLine($"Yes. Sum: {resultListSum}");
            }
            else
            {
                Console.WriteLine($"No. Diff: {Math.Abs(firstListSum - resultListSum)}");
            }
        }
    }
}