namespace SortArrayUsingBubbleSort
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SortArrayUsingBubbleSort
    {
        public static void Main()
        {
            var integerList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var swapped = false;

            do
            {
                swapped = false;
                for (int i = 0; i < integerList.Count - 1; i++)
                {
                    if (integerList[i] > integerList[i + 1])
                    {
                        Swap(integerList, i, i + 1);
                        swapped = true;

                    }
                }

            } while (swapped);

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