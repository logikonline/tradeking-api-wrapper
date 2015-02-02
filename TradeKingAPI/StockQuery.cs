using System;
using System.Text.RegularExpressions;

namespace TradeKingWrapper
{
    /// <summary>
    /// A query for information about a stock.
    /// </summary>
    public class StockQuery : QuoteQuery<StockDetail>
    {
        private static Regex symbolRegex = new Regex("^([A-Z]+)$");

        public string StockSymbol { get; private set; }

        public override string QueryUri
        {
            get
            {
                string parameters;
                if (fields.Count > 0)
                {
                    parameters = string.Format("symbols={0}&fids={1}", StockSymbol, string.Join(",", fields));
                }
                else
                {
                    parameters = string.Format("symbols={0}", StockSymbol);
                }

                var query = string.Format("https://api.tradeking.com/v1/market/ext/quotes.json?{0}", parameters);
                // Required to get commas to work correctly when genereating the OAuth signature.
                return query.Replace(",", "%2C");
            }
        }

        public StockQuery(string symbol)
        {
            if (string.IsNullOrWhiteSpace(symbol))
            {
                throw new ArgumentException("symbol");
            }

            symbol = symbol.ToUpper();
            if (!symbolRegex.Match(symbol).Success)
            {
                throw new ArgumentException(string.Format("'{0}' is not a valid stock symbol", symbol));
            }

            StockSymbol = symbol;
        }
    }
}
