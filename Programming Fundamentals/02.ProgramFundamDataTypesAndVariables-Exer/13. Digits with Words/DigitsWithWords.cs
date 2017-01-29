//Create a program that reads a digit in the form of a word and prints the digit as a number

using System;

class DigitsWithWords
{
    static void Main()
    {
        string input = Console.ReadLine();
        switch (input)
        {
            case "zero":
                Console.WriteLine(0);
                break;
            case "one":
                Console.WriteLine(1);
                break;
            case "two":
                Console.WriteLine(2);
                break;
            case "three":
                Console.WriteLine(3);
                break;
            case "four":
                Console.WriteLine(4);
                break;
            case "five":
                Console.WriteLine(5);
                break;
            case "six":
                Console.WriteLine(6);
                break;
            case "seven":
                Console.WriteLine(7);
                break;
            case "eight":
                Console.WriteLine(8);
                break;
            case "nine":
                Console.WriteLine(9);
                break;
            default:
                Console.WriteLine("not a digit");
                break;
        }
    }
}
