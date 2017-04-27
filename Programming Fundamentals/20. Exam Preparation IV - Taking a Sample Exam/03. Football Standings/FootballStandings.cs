namespace FootballStandings
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class FootballStandings
    {
        public static void Main()
        {
            var key =  Regex.Escape(Console.ReadLine());

            var pattern = $@"^.*(?:{key})(?<team1>[a-zA-Z]*)(?:{key}).* .*(?:{key})(?<team2>[a-zA-Z]*)(?:{key}).* (?<team1Score>\d+):(?<team2Score>\d+).*$";

            var teamScores = new Dictionary<string, Score>();

            var line = Console.ReadLine();
            while (line != "final")
            {
                var match = Regex.Match(line, pattern);

                if (!match.Success)
                {
                    line = Console.ReadLine();
                    continue;
                }

                var team1Name = new string(match.Groups["team1"].Value.ToUpper().Reverse().ToArray());
                var team2Name = new string(match.Groups["team2"].Value.ToUpper().Reverse().ToArray());
                var team1Goals = int.Parse(match.Groups["team1Score"].Value);
                var team2Goals = int.Parse(match.Groups["team2Score"].Value);

                if (!teamScores.ContainsKey(team1Name))
                {
                    teamScores[team1Name] = new Score();
                }

                if (!teamScores.ContainsKey(team2Name))
                {
                    teamScores[team2Name] = new Score();
                }

                // wint: 3 point, tie: 1 point each, loss: 0 points

                if (team1Goals > team2Goals)
                {
                    teamScores[team1Name].Points += 3;
                }
                else if (team1Goals == team2Goals) //tie
                {
                    teamScores[team1Name].Points ++;
                    teamScores[team2Name].Points ++;
                }
                else // team 2 wins
                {
                    teamScores[team2Name].Points += 3;
                }

                teamScores[team1Name].Goals += team1Goals;
                teamScores[team2Name].Goals += team2Goals;
                line = Console.ReadLine();
            }

            Console.WriteLine("League standings:");

            var leaqueStandings = teamScores.OrderByDescending(a => a.Value.Points).ThenBy(a => a.Key);
            var place = 1;
            foreach (var leaqueStanding in leaqueStandings)
            {
                var teamName = leaqueStanding.Key;
                var teamPoints = leaqueStanding.Value.Points;

                Console.WriteLine($"{place++}. {teamName} {teamPoints}");
            }

            Console.WriteLine("Top 3 scored goals:");

            var top3Goals = teamScores.
                OrderByDescending(a => a.Value.Goals)
                .ThenBy(a => a.Key)
                .Take(3);

            foreach (var teamGoals in top3Goals)
            {
                var teamName = teamGoals.Key;
                var goals = teamGoals.Value.Goals;

                Console.WriteLine($"- {teamName} -> {goals}");
            }
        }
    }

    internal class Score
    {
        public decimal Points { get; set; }
        public decimal Goals { get; set; }
    }
}
