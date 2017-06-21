using System;
using System.Collections.Generic;
using System.Linq;

public class MinEvenNumber
{
    public static void Main()
    {

        try
        {
            Console.WriteLine("{0:f2}", Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .Where(n => n % 2 == 0)
                .Min());

        }
        catch (Exception ex)
        {
            Console.WriteLine("No match");
        }
    }
}