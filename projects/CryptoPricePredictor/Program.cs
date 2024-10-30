using Newtonsoft.Json;

namespace CryptoPricePredictor
{
    public class Program
    {
        private static readonly HttpClient httpClient = new HttpClient();

        static async Task Main(string[] args)
        {
            Console.WriteLine("Welcome to my crypto price predictor!\n");

            Console.Write("Enter the name of the cryptocurrency (e.g. bitcoin, ethereum): ");
            string cryptoName = Console.ReadLine()!;

            Console.Write("Enter the number of days back to consider for prediction: ");
            string daysBack = Console.ReadLine()!;

            List<double> historicalPrices = await GetHistoricalPrices(cryptoName, int.Parse(daysBack));

            if (historicalPrices.Count == 0)
            {
                Console.WriteLine("No historical prices found for the given cryptocurrency.");
                return;
            }

            PricePredictor predictor = new PricePredictor(historicalPrices);

            double predictedPrices = predictor.PredictNextPrice();

            Console.WriteLine($"\nThe predicted price of {cryptoName} for the next day is: {predictedPrices}");
        }

        private static async Task<List<double>> GetHistoricalPrices(string cryptoName, int daysBack = 30)
        {
            List<double> prices = new List<double>();
            string url = $"https://api.coingecko.com/api/v3/coins/{cryptoName}/market_chart?vs_currency=usd&days={daysBack}";

            try
            {
                var response = await httpClient.GetStringAsync(url);

                dynamic data = JsonConvert.DeserializeObject(response)!;

                foreach (var item in data["prices"])
                {
                    prices.Add((double)item[1]);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to fetch historical prices. Please check your internet connection and try again.");
            }

            return prices;
        }
    }
}
