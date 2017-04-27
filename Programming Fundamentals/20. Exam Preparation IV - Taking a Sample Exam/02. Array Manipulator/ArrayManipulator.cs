using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    public class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                var commandParts = line
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                switch (commandParts[0])
                {
                    case "exchange":
                        arr = Exchange(arr, int.Parse(commandParts[1]));
                        break;
                    case "max":
                    case "min":
                        MaxAndMin(arr, commandParts[0], )
                        break;
                    case "first":

                        break;
                }
            }

            var arrAsString = string.Join(", ", arr);
            Console.WriteLine($"{arrAsString}");
        }

        private static int[] Exchange(int[] arr, int index)
        {
            var left = arr.Take(index + 1);
            var right = arr.Skip(index + 1);

            return right.Concat(left).ToArray();

        }
    }
}
