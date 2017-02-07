namespace SmallestElementInArray
{
    using System;
    using System.Linq;

    public class SmallestElementInArray
    {
        public static void Main(string[] args)
        {
            var stringArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var smallest = int.MaxValue;

            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i] < smallest)
                {
                    smallest = stringArray[i];
                }
            }

            Console.WriteLine(smallest);
        }
    }
}
