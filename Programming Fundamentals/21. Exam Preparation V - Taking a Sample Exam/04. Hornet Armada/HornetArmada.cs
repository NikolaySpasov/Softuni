using System;
using System.Collections.Generic;

namespace HornetArmada
{
    public class SoldierInfo
    {
        public int LastActivity { get; set; }
        public string LegionName { get; set; }
        public string Type { get; set; }
        public long Count { get; set; }
        public int Order { get; set; }
    }

    public class SolInfo
    {
        public string Type { get; set; }
        public string Count { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var soldiers = new List<SoldierInfo>();
            var activities = new Dictionary<string, int>();
            var orders = new Dictionary<string, int>();

            var order = 0;

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine()
                    .Split(new[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);

                var lastActivity = int.Parse(line[0]);
                var lastlegionName = line[1];

                if (!activities.ContainsKey(lastlegionName) || activities[lastlegionName] < lastActivity)
                {
                    activities[lastlegionName] = lastActivity;
                }

                order++;

                if (!orders.ContainsKey(lastlegionName) || orders[lastlegionName] > order)
                {
                    orders[lastlegionName] = order;
                }

                soldiers.Add(new SoldierInfo
                {
                    LastActivity = activities[lastlegionName],
                    LegionName = lastlegionName,
                    Type = line[2],
                    Count = long.Parse(line[3]),
                    Order = order

                });

            }

            foreach (var soldierInfo in soldiers)
            {
                soldierInfo.LastActivity = activities[soldierInfo.LegionName];
                soldierInfo.Order = orders[soldierInfo.LegionName];
            }

            var command = Console.ReadLine();
            if (command.Contains("\\"))
            {
                var commandParts = command.Split('\\');
                var activity = int.Parse(commandParts[0]);
                var soldierType = commandParts[1];

                var result = soldiers
                    .Where(s => s.Type == soldierType && s.LastActivity < activity)
                    .GroupBy(s => s.LegionName)
                    .Select(gr => new
                    {
                        LegionName = gr.Key,
                        Count = gr.Sum(s => s.Count),
                        Order = gr.Max(s => s.Order)
                    })
                    .OrderByDescending(s => s.Count)
                    .ToList();

                foreach (var info in result)
                {
                    Console.WriteLine($"{info.LegionName} -> {info.Count}");
                }

            }
        }
    }
}
