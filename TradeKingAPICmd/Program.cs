using TradeKingWrapper;
using System;
using System.Collections.Generic;

namespace TradeKingWrapperCmd
{
    class Program
    {
        const string consumerKey = "yourConsumerKey";
        const string consumerSecret = "yourConsumerSecret";
        const string oAuthToken = "yourOAuthToken";
        const string oAuthSecretToken = "yourOAuthSecretToken";

        static void Main(string[] args)
        {
            var api = new TradeKingAPI(consumerKey, consumerSecret, oAuthToken, oAuthSecretToken);
            var query = new StockQuery("MSFT");
            var details = new List<StockDetail>();
            details.Add(Args.Stock.Symbol);
            details.Add(Args.Stock.DailyHigh);
            details.Add(Args.Stock.AverageDailyPrice100);

            var result = api.Execute(query);
            foreach (var detail in details)
            {
                Console.WriteLine("{0}: {1}", detail.Description, result[detail]);
            }
        }
    }
}
