namespace IntegerInsertion
{
    using System;
    using System.Linq;

    public class IntegerInsertion
    {
        public static void Main()
        {
            var line = Console.ReadLine().Split().Select(int.Parse).ToList();
            var inputString = Console.ReadLine();

            while (inputString != "end")
            {
                var position = int.Parse(inputString[0].ToString());
                var value = int.Parse(inputString);

                line.Insert(position, value);

                inputString = Console.ReadLine();
            }

            Console.WriteLine(string.Join(" ", line));
        }
    }
}