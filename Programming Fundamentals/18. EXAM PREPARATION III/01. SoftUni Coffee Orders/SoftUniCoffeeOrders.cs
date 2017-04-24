namespace SoftUniCoffeeOrders
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class SoftUniCoffeeOrders
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            decimal totalPrice = 0M;
            //((daysInMonth * capsulesCount) * pricePerCapsule)
            for (int i = 0; i < n; i++)
            {
                decimal pricePercapsule = decimal.Parse(Console.ReadLine());

                DateTime orderDate = DateTime.ParseExact(Console.ReadLine(), "d/M/yyyy", CultureInfo.InvariantCulture);
                int capsuleCount = int.Parse(Console.ReadLine());

                decimal currentPrice = ((DateTime.DaysInMonth(orderDate.Year, orderDate.Month) * (long)capsuleCount) * pricePercapsule);
                Console.WriteLine($"The price for the coffee is: ${currentPrice:F2}");

                totalPrice += currentPrice;
            }

            Console.WriteLine($"Total: ${totalPrice:F2}");
        }
    }
}
