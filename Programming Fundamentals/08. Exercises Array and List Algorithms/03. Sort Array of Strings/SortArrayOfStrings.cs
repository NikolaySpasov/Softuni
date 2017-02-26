namespace SortArrayOfStrings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class SortArrayOfStrings
    {
        static void Main()
        {
            var stringArray = Console.ReadLine().Split().ToList();
            var swapped = false;

            do
            {
                swapped = false;
                for (int i = 0; i < stringArray.Count - 1; i++)
                {
                    if (stringArray[i].CompareTo(stringArray[i + 1]) > 0)
                    {
                        Swap(stringArray, i, i + 1);
                        swapped = true;

                    }
                }

            } while (swapped);

            Console.WriteLine(string.Join(" ", stringArray));
        }

        private static void Swap(List<string> stringArray, int currentElement, int followElement)
        {
            var temp = stringArray[currentElement];
            stringArray[currentElement] = stringArray[followElement];
            stringArray[followElement] = temp;
        }
    }
}