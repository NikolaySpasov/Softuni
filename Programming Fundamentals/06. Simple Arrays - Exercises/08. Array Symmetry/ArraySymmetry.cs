namespace _08.Array_Symmetry
{
    using System;
    using System.Linq;

    class ArraySymmetry
    {
        static void Main()
        {
            string[] arrayOfStrings = Console.ReadLine().Split().ToArray();

            bool isSymmetric = true;
            for (int i = 0; i < arrayOfStrings.Length / 2; i++)
            {
                if (arrayOfStrings[i] != arrayOfStrings[arrayOfStrings.Length - 1 - i])
                {
                    isSymmetric = false;
                    break;
                }
            }
            if (isSymmetric)
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
