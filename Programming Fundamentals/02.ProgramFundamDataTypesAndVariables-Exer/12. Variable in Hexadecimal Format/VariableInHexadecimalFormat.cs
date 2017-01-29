//Write a program that reads a number in hexadecimal format(0x##) convert it to decimal format and prints it.

using System;

class VariableInHexadecimalFormat
{
    static void Main()
    {
        string number = Console.ReadLine();
        Console.WriteLine(Convert.ToInt32(number, 16));
    }
}

