namespace _MultiplyAnArrayOfDoubles
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var stringArr = Console.ReadLine().Split();

            var arr = new double[stringArr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(stringArr[i]);
            }

            var p = double.Parse(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] *= p;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}