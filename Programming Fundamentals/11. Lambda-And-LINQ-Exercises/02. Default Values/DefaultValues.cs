namespace DefaultValues
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class DefaultValues
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var keyAndValue = new Dictionary<string, string>();

            while (!inputLine.Equals("end"))
            {
                var inputLineArguments = inputLine.Split(new[] {' ', '-', '>'}, StringSplitOptions.RemoveEmptyEntries);
                var key = inputLineArguments[0];
                var value = inputLineArguments[1];

                keyAndValue[key] = value;
                inputLine = Console.ReadLine();
            }

            var defaultValue = Console.ReadLine();

             keyAndValue
                .Where(x => x.Value != "null")
                .OrderByDescending(x => x.Value.Length)
                .ToList()
                .ForEach(x => Console.WriteLine("{0} <-> {1}", x.Key, x.Value));


            keyAndValue
                .Where(x => x.Value == "null")
                .Select(x => x.Key + " <-> " + defaultValue)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
