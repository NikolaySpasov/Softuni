//Write a method that receives a name as parameter and prints on the console. “Hello, <name>!”

using System;

namespace _01.Hello__Name_
{
    class HelloName
    {
        static void Main()
        {
            string name = Console.ReadLine();
            PrintName(name);
        }

        private static void PrintName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
