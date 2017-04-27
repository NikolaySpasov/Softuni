namespace SweetDessert
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class SweetDessert
    {
        public static void Main()
        {
            decimal amountOfCash = decimal.Parse(Console.ReadLine());
            int numberOfGuests = int.Parse(Console.ReadLine());
            decimal priceOfBananas = decimal.Parse(Console.ReadLine());
            decimal priceOfEggs = decimal.Parse(Console.ReadLine());
            decimal priceOfBerries = decimal.Parse(Console.ReadLine());

            var portions = numberOfGuests / 6;

            if (numberOfGuests % 6 != 0)
            {
                portions++;
            }

            var pricePerPortion = 2 * priceOfBananas + 4 * priceOfEggs + 0.2m * priceOfBerries;
            var totalPrice = pricePerPortion * portions;

            var moneyLeft = amountOfCash - totalPrice;

            if (moneyLeft >= 0)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {totalPrice:F2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {Math.Abs(moneyLeft):F2}lv more.");
            }
        }
    }
}
