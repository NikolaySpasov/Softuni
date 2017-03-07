namespace ForumTopics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ForumTopics
    {
        public static void Main()
        {
            var lineInput = Console.ReadLine();
            var forumTopics = new Dictionary<string, List<string>>();

            while (lineInput != "filter")
            {
                var tokens = lineInput.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var topics = tokens[0];
                var tags = tokens[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < tags.Length; i++)
                {
                    if (!forumTopics.ContainsKey(topics))
                    {
                        forumTopics[topics] = new List<string>();
                    }

                    forumTopics[topics].Add(tags[i]);
                }
                lineInput = Console.ReadLine();
            }

            var filter = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var kvp in forumTopics)
            {
                var topic = kvp.Key;
                var tag = kvp.Value;
                for (int i = 0; i < filter.Length; i++)
                {
                    if ((tag + "") == filter[i])
                    {
                        Console.Write("{0}| #", topic);
                        Console.WriteLine(string.Join(", #", tag));

                    }

                }

            }
        }
    }
}
