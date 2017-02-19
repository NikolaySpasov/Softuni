namespace FlipListSides
{
    using System;
    using System.Linq;

    class FlipListSides
    {
        static void Main()
        {
            var numberList = Console.ReadLine().Split().Select(int.Parse).ToList();

            int temp;
            for (int i = 1; i <= (numberList.Count - 1) / 2; i++)
            {
                temp = numberList[i];
                numberList[i] = numberList[numberList.Count - 1 - i];
                numberList[numberList.Count -1 - i] = temp;
            }

            Console.WriteLine(string.Join(" ", numberList));
        }
    }
}
