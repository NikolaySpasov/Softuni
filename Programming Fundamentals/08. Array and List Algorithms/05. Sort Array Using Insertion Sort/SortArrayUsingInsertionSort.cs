namespace SortArrayUsingInsertionSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortArrayUsingInsertionSort
    {
        public static void Main()
        {
            var integerList = Console.ReadLine().Split().Select(int.Parse).ToList();

            for (int firstUnsorted = 0; firstUnsorted < integerList.Count - 1; firstUnsorted++)
            {
                var i = firstUnsorted + 1;
                while (i > 0)
                {
                    if (integerList[i - 1] > integerList[i])
                        Swap(integerList, i, i - 1); 
                    i--;
                }
            }

            Console.WriteLine(string.Join(" ",integerList));

        }

        private static void Swap(List<int> integerList, int currentElement, int followElement)
        {
            int temp = integerList[currentElement];
            integerList[currentElement] = integerList[followElement];
            integerList[followElement] = temp;

        }
    }
}
