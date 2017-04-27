namespace HornetComm
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class HornetComm
    {
        public static void Main()
        {
            var messages = new List<string>();
            var broadcats = new List<string>();

            while (true)
            {
                var line = Console.ReadLine();

                if (line == "Hornet is Green")
                {
                    break;
                }

                var parts = line.Split(
                    new[] { " <-> " }, StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length != 2)
                {
                    continue;
                }

                var firstQuery = parts[0];
                var secondQuery = parts[1];

                if (firstQuery.All(char.IsDigit) && secondQuery.All(char.IsLetterOrDigit))
                {
                    string revesedQuery = new string(firstQuery.Reverse().ToArray());

                    messages.Add($"{revesedQuery} -> {secondQuery}");
                }
                else if (firstQuery.All(s => !char.IsDigit(s)) && secondQuery.All(char.IsLetterOrDigit))
                {
                    var transformed = new StringBuilder();

                    foreach (var symbol in secondQuery)
                    {
                        if (char.IsUpper(symbol))
                        {
                            transformed.Append(char.ToLower(symbol));
                        }
                        else if (char.IsLower(symbol))
                        {
                            transformed.Append(char.ToUpper(symbol));
                        }
                        else
                        {
                            transformed.Append(symbol);
                        }
                    }

                    broadcats.Add($"{transformed} -> {firstQuery}");
                }
            }

            Console.WriteLine("Broadcasts:");
            Console.WriteLine(broadcats.Any()
                ? string.Join(Environment.NewLine, broadcats)
                : "None");

            Console.WriteLine("Messages:");
            Console.WriteLine(messages.Any()
                ? string.Join(Environment.NewLine, messages)
                : "None");
        }
    }
}
