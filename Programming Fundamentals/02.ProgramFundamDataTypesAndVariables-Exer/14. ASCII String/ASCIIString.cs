//Create a program that reads a number N.
//On the next N lines, it reads integers from the ASCII table.
//The task is to concatenate everything in string format.


using System;



class ASCIIString
{
    static void Main()
    {
        string result = "";
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());
            char letter = Convert.ToChar(number);
            result += (char)number;
        }
        Console.WriteLine($"{result}");
    }
}

