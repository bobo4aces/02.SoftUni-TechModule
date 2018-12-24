using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numberOfPrices = int.Parse(Console.ReadLine());
        double significanceThreshold = double.Parse(Console.ReadLine());
        double lastPrice = double.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfPrices - 1; i++)
        {
            double currentPrice = double.Parse(Console.ReadLine());
            double difference = Proc(lastPrice, currentPrice);
            bool isSignificantDifference = significantDifference(difference, significanceThreshold);
            string message = GetMessage(currentPrice, lastPrice, difference, isSignificantDifference);
            Console.WriteLine(message);
            lastPrice = currentPrice;
        }
    }

    private static string GetMessage(double currentPrice, double lastPrice, double difference, bool significantDifference)
    {
        string message = "";
        if (difference == 0)
        {
            message = string.Format("NO CHANGE: {0}", currentPrice);
        }
        else if (!significantDifference)
        {
            message = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference*100);
        }
        else if (significantDifference && (difference > 0))
        {
            message = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        }
        else if (significantDifference && (difference < 0))
            message = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", lastPrice, currentPrice, difference * 100);
        return message;
    }

    private static bool significantDifference(double significanceThreshold, double difference)
    {
        if (Math.Abs(significanceThreshold) >= difference)
        {
            return true;
        }
        return false;
    }

    private static double Proc(double lastPrice, double currentPrice)
    {
        double difference = (currentPrice - lastPrice) / lastPrice;
        return difference;
    }
}
