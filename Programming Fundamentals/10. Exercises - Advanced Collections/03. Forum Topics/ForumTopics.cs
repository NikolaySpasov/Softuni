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
            var forumTopics = new Dictionary<string, HashSet<string>>();

            while (lineInput != "filter")
            {
                var tokens = lineInput.Split("->".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                var topics = tokens[0];
                var tags = tokens[1].Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < tags.Length; i++)
                {
                    if (!forumTopics.ContainsKey(topics))
                    {
                        forumTopics[topics] = new HashSet<string>();
                    }

                    forumTopics[topics].Add(tags[i]);
                }
                lineInput = Console.ReadLine();
            }

            var checkTag = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (var kvp in forumTopics)
            {
                var topic = kvp.Key;
                var tag = kvp.Value;
                var counter = 0;

                for (int i = 0; i < checkTag.Length; i++) //iterate over the search array
                {
                    if (kvp.Value.Contains(checkTag[i])) //if the KVP value contains a word from the search array
                    {
                        counter++;
                    }
                }

                if (checkTag.Length == counter)
                {
                    Console.WriteLine($"{topic} | #{string.Join(", #", tag)}");
                }

            }
        }
    }
}
