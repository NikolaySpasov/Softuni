namespace Template
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main()
        {
            var listM = new List<int>(5);
            listM[3] = 65; 
            Console.WriteLine(string.Join(" ",listM));

        }
    }
}
