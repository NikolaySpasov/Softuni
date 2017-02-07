namespace RotateArray_OfStrings
{
    using System;
    using System.Linq;

    public class RotateArrayOfStrings
    {
        public static void Main()
        {
            string[] stringArray = Console.ReadLine().Split().ToArray();
            var rotatedArray = new string[stringArray.Length];

            for (int i = 0; i < stringArray.Length - 1; i++)
            {
                rotatedArray[i + 1] = stringArray[i];
            }

            var lastElement = stringArray[rotatedArray.Length - 1];
            rotatedArray[0] = lastElement;

            Console.WriteLine(string.Join(" ", rotatedArray));
        }
    }
}
