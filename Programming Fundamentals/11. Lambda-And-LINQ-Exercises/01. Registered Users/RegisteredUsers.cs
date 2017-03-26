namespace RegisteredUsers
{
    using System;
    using System.Globalization;
    using System.Collections.Generic;
    using System.Linq;

    public class RegisteredUsers
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var usernameAndData = new Dictionary<string, DateTime>();
            var result = new List<string>();

            while (!inputLine.Equals("end"))
            {
                var separator = " ->".ToCharArray();
                var inputLineArguments = inputLine.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                var name = inputLineArguments[0];
                var date = DateTime.ParseExact(inputLineArguments[1],"dd/MM/yyyy",CultureInfo.InvariantCulture);

                usernameAndData[name] = date;
                inputLine = Console.ReadLine();
            }

            var orderedUsernames = usernameAndData
                                    .Reverse()
                                    .OrderBy(x => x.Value)
                                    .Take(5)
                                    .OrderByDescending(x => x.Value)
                                    .ToDictionary(x => x.Key, x => x.Value);

            Console.WriteLine(string.Join(Environment.NewLine, orderedUsernames.Keys));
        }
    }
}