namespace Template
{
    using System;
    using System.Linq;

    public class StuckZipper
    {
        public static void Main()
        {
            var firstLine = Console.ReadLine().Split().Select(int.Parse).ToList();
            var secondLine = Console.ReadLine().Split().Select(int.Parse).ToList();

            int idealNumOfMinDigits = int.MaxValue;

            foreach (var number in firstLine)
            {
                var currentNumberDigitsCount = Math.Abs(number).ToString().Length;
                if (currentNumberDigitsCount < idealNumOfMinDigits)
                {
                    idealNumOfMinDigits = Math.Abs(number).ToString().Length;
                }
            }

            foreach (var number in secondLine)
            {
                var currentNumberDigitsCount = Math.Abs(number).ToString().Length;
                if (currentNumberDigitsCount < idealNumOfMinDigits)
                {
                    idealNumOfMinDigits = Math.Abs(number).ToString().Length;
                }
            }

            for (int i = 0; i < firstLine.Count; i++)
            {
                if (Math.Abs(firstLine[i]).ToString().Length > idealNumOfMinDigits)
                {
                    firstLine.RemoveAt(i);
                    i--;
                }
            }

            for (int i = 0; i < secondLine.Count; i++)
            {
                if (Math.Abs(secondLine[i]).ToString().Length > idealNumOfMinDigits)
                {
                    secondLine.RemoveAt(i);
                    i--;
                }
            }

            int indexCount = 1;

            for (int i = 0; i < firstLine.Count; i++)
            {
                secondLine.Insert(Math.Min(indexCount, secondLine.Count), firstLine[i]);
                indexCount += 2;
            }

            Console.WriteLine(string.Join(" ", secondLine));
        }
    }
}