using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Char_Rotation
{
    class CharRotation
    {
        static void Main(string[] args)
        {
            string strArray = Console.ReadLine();
            int[] intArray = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < intArray.Length; i++)
            {
                if (intArray[i] % 2 == 0)
                {
                    char currentCharacter = (char)(strArray[i] - intArray[i]);
                    Console.Write(currentCharacter);
                }
                else if (intArray[i] % 2 == 1)
                {
                    char currentCharacter = (char)(strArray[i] + intArray[i]);
                    Console.Write(currentCharacter);
                }
            }

            Console.WriteLine();
        }
    }
}
