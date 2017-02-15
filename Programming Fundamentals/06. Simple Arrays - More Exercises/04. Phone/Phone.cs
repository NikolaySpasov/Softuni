using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Phone
{
    class Phone
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine().Split().ToArray();
            string[] names = Console.ReadLine().Split().ToArray();

            if

            Call(phoneNumbers, names);
        }

        private static void Call(string[] phoneNumbers, string[] names)
        {
            string name = Console.ReadLine();
            while (name != "done")
            {
                int sumOfDigits = 0;
                for (int i = 0; i < phoneNumbers.Length; i++)
                {
                    char currentCharacter = char.Parse(phoneNumbers[i]);
                    if (currentCharacter >= '0' && currentCharacter <= '9')
                    {
                        sumOfDigits += int.Parse(phoneNumbers[i]);

                        if (sumOfDigits % 2 == 1)
                        {
                            Console.WriteLine("no answer");
                        }
                        else
                        {
                            Console.WriteLine("call ended");
                        }
                    }
                }

                name = Console.ReadLine();
            }
        }
    }
}
