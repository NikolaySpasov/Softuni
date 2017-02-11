namespace _03.Count_of_Given_Element_in_Array
{
    using System;
    using System.Linq;

    class CountOfGivenElementInArray
    {
        static void Main(string[] args)
        {
            var stringArray = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var existingElement = int.Parse(Console.ReadLine());

            int count = 0;
            for (int i = 0; i < stringArray.Length; i++)
            {
                if (stringArray[i] == existingElement)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
