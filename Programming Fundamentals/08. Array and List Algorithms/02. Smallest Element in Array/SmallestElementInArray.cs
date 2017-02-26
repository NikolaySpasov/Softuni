namespace SmallestElementInArray
{
    using System;
    using System.Linq;

    public class SmallestElementInArray
    {
        public static void Main()
        {
            var integerList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var smallestInt = int.MaxValue;

            for (int i = 0; i < integerList.Count; i++)
            {
                if (integerList[i] < smallestInt)
                {
                    smallestInt = integerList[i];
                }
            }

            Console.WriteLine(smallestInt);
        }
    }
}
