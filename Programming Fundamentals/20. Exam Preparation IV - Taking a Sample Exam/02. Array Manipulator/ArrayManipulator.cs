namespace ArrayManipulator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ArrayManipulator
    {
        public static void Main()
        {
            var arr = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var result = new List<int>();

            while (true)
            {
                var line = Console.ReadLine(); 
                if (line != "end" )
                {
                    var commands = Console.ReadLine().Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                    switch (commands[0])
                    {
                        case "exchange":
                            arr = Exchange(arr,int.Parse(commands[1]));
                            break;
                        case "max":
                        case "min":
                            Min(arr);
                            break;
                        case "firts":
                            First(arr);
                            break;
                        case "last":
                            Last(arr);
                            break;
                    }
                
                }

                line = Console.ReadLine();
            }
        }

        private static int[] arr Exchange(int[] arr, int index)
        {

            return;
        }
    }
}
