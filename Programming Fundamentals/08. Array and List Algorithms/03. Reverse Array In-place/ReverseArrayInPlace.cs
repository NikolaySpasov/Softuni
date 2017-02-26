namespace ReverseArrayInPlace
{
    using System;
    using System.Linq;

    class ReverseArrayInPlace
    {
        static void Main()
        {
            var integerList = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int i = 0; i < integerList.Count / 2; i++)
            {
                int temp = integerList[i];
                integerList[i] = integerList[integerList.Count -1 - i];
                integerList[integerList.Count - 1 - i] = temp; 
            }

            Console.WriteLine(string.Join(" ",integerList));
        }
    }
}
