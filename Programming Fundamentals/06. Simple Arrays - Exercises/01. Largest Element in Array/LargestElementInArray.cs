namespace _01.Largest_Element_in_Array
{
    using System;

    class LargestElementInArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            int maxElement = int.MinValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] > maxElement)
                {
                    maxElement = numbers[i];
                }
            }
            Console.WriteLine(maxElement);
        }
    }
}
