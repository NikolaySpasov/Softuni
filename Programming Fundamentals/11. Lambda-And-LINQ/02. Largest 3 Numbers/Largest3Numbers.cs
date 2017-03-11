namespace Largest3Numbers
{
    using System;
    using System.Linq;

    public class Largest3Numbers
    {
        public static void Main()
        {
            Console.WriteLine(string.Join(" ", Console.ReadLine().Split(' ').Select(int.Parse).OrderByDescending(x => x).Take(3).ToList()));
        }
    }
}
