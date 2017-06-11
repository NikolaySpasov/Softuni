using System;

class StringLength
{
    static void Main()
    {
        string sentense = Console.ReadLine();

        if (sentense.Length <= 20)
        {
            Console.WriteLine(sentense.PadRight(20, '*'));
        }
        else
        {
            Console.WriteLine(sentense.Substring(0, 20));
        }
    }
}