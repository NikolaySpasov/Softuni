using System;

class ExactProductofRealNumbers
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        double product = 1;
        for (int i = 0; i < n-1; i++)
        {
            product *= double.Parse(Console.ReadLine());
        }
        Console.WriteLine(product);
    }
}