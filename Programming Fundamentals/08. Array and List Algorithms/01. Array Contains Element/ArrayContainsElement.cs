namespace ArrayContainsElement
{
    using System;
    using System.Linq;

    public class ArrayContainsElement
    {
        public static void Main()
        {
            var integerList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var foundNumber = int.Parse(Console.ReadLine());

            var containsElement = false;
            foreach (var item in integerList)
            {
                if (item == foundNumber)
                {
                    containsElement = true;
                    break;
                }
            }

            if (containsElement)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
