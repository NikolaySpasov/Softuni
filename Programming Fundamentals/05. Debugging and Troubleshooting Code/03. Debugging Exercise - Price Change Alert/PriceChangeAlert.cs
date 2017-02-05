using System;

public class PriceChangeAlert
{
    public static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        double treshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < number - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double precentageDiffrence = GetPercentage(lastPrice, currentPrice);
            bool hasDifference = ImaliDif(precentageDiffrence, treshold);
            string message = Get(currentPrice, lastPrice, precentageDiffrence, hasDifference);
            Console.WriteLine(message);
            lastPrice = currentPrice;
        }
    }

    public static string Get(double currentPrice, double lastPrice, double precentageDiffrence, bool hasDifference)
    {
        string to = string.Empty;
        if (precentageDiffrence == 0)
        {
            to = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!hasDifference)
        {
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:E2}%)", lastPrice, currentPrice, precentageDiffrence);
        }
        else if (hasDifference && (precentageDiffrence > 0))
        {
            to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, precentageDiffrence);
        }
        else if (hasDifference && (precentageDiffrence < 0))
        {
            to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, precentageDiffrence);
        }

        return to;
    }

    public static bool ImaliDif(double treshold, double isDiff)
    {
        if (Math.Abs(treshold) >= isDiff)
        {
            return true;
        }

        return false;
    }

    public static double GetPercentage(double l, double c)
    {
        double r = (c - l) / l;
        return r;
    }
}
