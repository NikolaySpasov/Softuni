namespace Phonebook
{
    using System;
    using System.Linq;

    class Phonebook
    {
        static void Main()
        {
            string[] phoneNumbers = Console.ReadLine().Split().ToArray();
            string[] names = Console.ReadLine().Split().ToArray();

            string name = Console.ReadLine();
            while (name != "done")
            {

                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                        Console.WriteLine($"{names[i]} -> {phoneNumbers[i]}");
                    }
                }
                name = Console.ReadLine();
            }
        }
    }
}