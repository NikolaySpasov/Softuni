namespace RemoveElementsAtOddPositions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class RemoveElementsAtOddPositions
    {
        static void Main()
        {
            var input = Console.ReadLine().Split(' ').ToList();
            var result = new List<string>();

            for (int i = 1; i < input.Count; i+=2)
            {
                result.Add(input[i]);
            }

            Console.WriteLine(string.Join("",result));
        }
    }
}
