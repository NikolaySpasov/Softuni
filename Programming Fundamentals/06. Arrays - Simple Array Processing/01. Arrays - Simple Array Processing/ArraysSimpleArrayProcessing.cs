namespace ArraysSimpleArrayProcessing
{
    using System;

    public class ArraysSimpleArrayProcessing
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] numbers = new int[n];

            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            } 
                Console.WriteLine(sum);
        }
    }
}
