namespace FourthTask
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class FourthTask
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries ).ToArray();
            var worms = new Dictionary<string, Dictionary<string, int>>();
            var result = new Dictionary<string, Dictionary<string, int>>();

            while (inputLine[0] != "quit")
            {
                var wormName = inputLine[0];
                var teamName = inputLine[1];
                var wormScore = int.Parse(inputLine[2]);

                if (!worms.ContainsKey(wormName))
                {
                    worms[wormName] = new Dictionary<string, int>();
                }

                if (!worms[wormName].ContainsKey(teamName))
                {
                    worms[wormName][teamName] = 0;
                }


                worms[wormName][teamName] = wormScore;

                inputLine = Console.ReadLine().Split(new[] { " -> " }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }

            foreach (var worm in worms)
            {
                var wormName = worm.Key;
                var teamName = worm.Value;

                worm[wormNam]
            }

            var number = 1;
            foreach (var worm in worms)
            {
                var wormName = worm.Key;
                var teamName = worm.Value;

                foreach (var team in wormName[teamName])
                {

                }


            }

        }
    }
}
