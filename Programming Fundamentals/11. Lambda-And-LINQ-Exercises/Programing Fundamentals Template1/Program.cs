namespace Template
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            Console.ReadLine()
                .Split(' ')
                .OrderByDescending(x => x)
                .Take(3).Select(x => x + " ")
                .ToList()
                .ForEach(Console.Write);
            Console.Read();

        }
    }
}
