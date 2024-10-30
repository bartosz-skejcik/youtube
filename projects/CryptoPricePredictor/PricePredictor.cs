public class PricePredictor
{
    private List<double> prices;
    private int daysCount;

    public PricePredictor(List<double> historicalPrices)
    {
        prices = historicalPrices;
        daysCount = historicalPrices.Count;
    }

    public double PredictNextPrice()
    {
        if (daysCount == 0)
            throw new InvalidOperationException("Not enough data to predict the next price.");

        double sumX = 0;
        double sumY = 0;
        double sumXY = 0;
        double sumX2 = 0;

        for (int i = 0; i < daysCount; i++)
        {
            sumX += i;
            sumY += prices[i];
            sumXY += i * prices[i];
            sumX2 += i * i;
        }

        double slope = (daysCount * sumXY - sumX * sumY) / (daysCount * sumX2 - sumX * sumX);
        double intercept = (sumY - slope * sumX) / daysCount;

        return slope * daysCount + intercept;
    }
}
