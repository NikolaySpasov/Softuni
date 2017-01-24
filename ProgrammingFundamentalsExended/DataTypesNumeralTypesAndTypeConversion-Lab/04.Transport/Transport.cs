using System;

class Transport
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int courses = (int)Math.Ceiling((double)n / (4 + 8 + 12));
        Console.WriteLine(courses);
    }
}