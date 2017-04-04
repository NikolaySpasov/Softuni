namespace Placeholders
{
    using System;

    public class Placeholders
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();

            while (!inputLine.Equals("end"))
            {
                var tokens = inputLine.Split(new[] { '-', '>' },StringSplitOptions.RemoveEmptyEntries );

                var sentense = tokens[0].Trim();
                var values = tokens[1].Trim().Split(new[] { ',', ' ' },StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < values.Length; i++)
                {
                    var currentPlaceholder = "{" + i + "}";

                    sentense = sentense.Replace(currentPlaceholder, values[i]);
                }

                Console.WriteLine(sentense);

                inputLine = Console.ReadLine();
            }
        }
    }
}
