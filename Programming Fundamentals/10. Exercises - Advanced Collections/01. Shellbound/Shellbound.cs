namespace Shellbound
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Shellbound
    {
        public static void Main()
        {
            var lineInput = Console.ReadLine();
            var regionAndSize = new Dictionary<string, HashSet<int>>();

            while (lineInput != "Aggregate")
            {
                var tokens = lineInput.Split();
                var name = tokens[0];
                var size = int.Parse(tokens[1]);
                if (regionAndSize.ContainsKey(name))
                {

                }

                if (!regionAndSize.ContainsKey(name))
                {
                    regionAndSize[name] = new HashSet<int>();
                }
               
                regionAndSize[name].Add(size);

                lineInput = Console.ReadLine();
            }

            foreach (var region in regionAndSize)
            {
                var name = region.Key;
                var sizes = region.Value;
                var giantShell = sizes.Sum() - (int)sizes.Average();

                Console.WriteLine("{0} -> {1} ({2})", name, string.Join(", ", sizes), giantShell);
            }
        }
    }
}
