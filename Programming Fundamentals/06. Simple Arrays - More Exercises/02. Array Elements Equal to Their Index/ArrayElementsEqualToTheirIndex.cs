namespace _02.Array_Elements_Equal_to_Their_Index
{
    using System;
    using System.Linq;

    class ArrayElementsEqualToTheirIndex
    {
        static void Main()
        {
            var stringArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i] == i)
                {
                    Console.Write($"{stringArray[i]} ");
                }
            }

            Console.WriteLine();
        }
    }
}