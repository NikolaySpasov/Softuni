namespace _05.Increasing_Sequence_of_Elements
{
    using System;
    using System.Linq;

    class EqualSequenceOfElementsInArray
    {
        static void Main(string[] args)
        {
            var stringArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            bool isEqual = true;
            for (int i = 1; i < stringArray.Length -1; i++)
            {
                if (stringArray[i] != stringArray[i - 1])
                {
                    isEqual = false;
                    break;
                }

            }

            if (isEqual)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}