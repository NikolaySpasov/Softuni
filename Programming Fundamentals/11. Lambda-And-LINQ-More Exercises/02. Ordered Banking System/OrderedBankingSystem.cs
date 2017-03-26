namespace OrderedBankingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OrderedBankingSystem
    {
        public static void Main()
        {
            var bankAccountBalance = new Dictionary<string, Dictionary<string, decimal>>();
            var inputLine = Console.ReadLine();

            while (inputLine != "end")
            {
                var inputLineArguments = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
       
                var bank = inputLineArguments[0];
                var account = inputLineArguments[1];
                var balance = decimal.Parse(inputLineArguments[2]);

                if (! bankAccountBalance.ContainsKey(bank))
                {
                    bankAccountBalance.Add(bank, new Dictionary<string, decimal>());
                }

                if (!bankAccountBalance[bank].ContainsKey(account))
                {
                    bankAccountBalance[bank].Add(account, 0);
                }

                bankAccountBalance[bank][account] += balance;

                inputLine = Console.ReadLine();
            }

            bankAccountBalance
                .OrderByDescending(bank => bank.Value.Sum(account => account.Value))
                .ThenByDescending(bank => bank.Value.Max(account => account.Value))
                .ToList()
                .ForEach(bank => bank.Value
                .OrderByDescending(account => account.Value)
                .ToList()
                .ForEach(account => Console.WriteLine("{0} -> {1} ({2})",account.Key,account.Value,bank.Key)));
        }
    }
}
