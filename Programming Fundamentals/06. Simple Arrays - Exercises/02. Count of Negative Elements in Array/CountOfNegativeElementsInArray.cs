namespace CountOfNegativeElementsInArray
{
    using System;

    class CountOfNegativeElementsInArray
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            int count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] < 0 )
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
