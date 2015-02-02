using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace TradeKingWrapper
{
    /// <summary>
    /// A query for information about an option.
    /// </summary>
    public class OptionQuery : QuoteQuery<OptionDetail>
    {
        private static readonly Regex optionRegex = new Regex("([A-Z]+)(\\d{2})(\\d{2})(\\d{2})(C|P)(\\d{8})");

        /// <summary>
        /// The symbol of the underlying security.
        /// </summary>
        public string StockSymbol { get; private set; }

        /// <summary>
        /// The option expiration year.
        /// </summary>
        public int ExpirationYear { get; private set; }

        /// <summary>
        /// The option expiration month.
        /// </summary>
        public int ExpirationMonth { get; private set; }

        /// <summary>
        /// The option expiration day.
        /// </summary>
        public int ExpirationDay { get; private set; }

        /// <summary>
        /// The option type, either Call or Put.
        /// </summary>
        public OptionType Type {get; private set; }

        /// <summary>
        /// The option strike price.
        /// </summary>
        public double StrikePrice { get; private set; }

        private string QueryStrikePrice
        {
            get
            {
                // The query strike price must be 8 digits, the last 3 behind the decimal.
                // For example, 00045000 is a $45 strike price.
                var strike = StrikePrice.ToString("#.000").Replace(".", string.Empty);
                while (strike.Length < 8)
                {
                    strike = "0" + strike;
                }
                return strike;
            }
        }

        /// <summary>
        /// The option symbol passed to the Trade King API.
        /// See https://developers.tradeking.com/documentation/market-ext-quotes-get-post for formatting information.
        /// </summary>
        public string OptionSymbol
        {
            get
            {
                var expiration = new DateTime(ExpirationYear, ExpirationMonth, ExpirationDay);
                return string.Format("{0}{1}{2}{3}{4}{5}",
                    StockSymbol,
                    expiration.ToString("yy"),
                    expiration.ToString("MM"),
                    expiration.ToString("dd"),
                    Type == OptionType.Call ? "C" : "P",
                    QueryStrikePrice);
            }
        }

        public override string QueryUri
        {
            get
            {
                string parameters;
                if (fields.Any())
                {
                    parameters = string.Format("symbols={0}&fids={1}", OptionSymbol, string.Join(",", fields));
                }
                else
                {
                    parameters = string.Format("symbols={0}", OptionSymbol);
                }

                var query = string.Format("https://api.tradeking.com/v1/market/ext/quotes.json?{0}", parameters);
                // Required to get commas to work correctly when genereating the OAuth signature.
                return query.Replace(",", "%2C");
            }
        }

        public OptionQuery(string optionSymbol)
        {
            if (string.IsNullOrWhiteSpace(optionSymbol))
            {
                throw new ArgumentException("optionSymbol is null or empty");
            }

            var match = optionRegex.Match(optionSymbol);
            if (!match.Success)
            {
                throw new IllegalOptionQueryException("'{0}' is not a valid option symbol. See https://developers.tradeking.com/documentation/market-ext-quotes-get-post", optionSymbol);
            }

            var type = match.Groups[5].Value.Equals("C") ? OptionType.Call : OptionType.Put;
            var strikeRepr = match.Groups[6].Value;
            // Add a decimal point 5 digits in to parse correctly.
            var strikePrice = double.Parse(strikeRepr.Substring(0, 5) + "." + strikeRepr.Substring(5, 3));

            Set(stockSymbol: match.Groups[1].Value,
                expirationYear: int.Parse(match.Groups[2].Value),
                expirationMonth: int.Parse(match.Groups[3].Value),
                expirationDay: int.Parse(match.Groups[4].Value),
                type: type,
                strikePrice: strikePrice);
        }

        public OptionQuery(string stockSymbol, int expirationYear, int expirationMonth, int expirationDay, OptionType type, double strikePrice)
        {
            if (string.IsNullOrWhiteSpace(stockSymbol))
            {
                throw new ArgumentException("stockSymbol is null or empty");
            }

            Set(stockSymbol, expirationYear, expirationMonth, expirationDay, type, strikePrice);         
        }

        public OptionQuery(string stockSymbol, DateTime expirationDate, OptionType type, double strikePrice) 
            : this(stockSymbol, expirationDate.Year, expirationDate.Month, expirationDate.Day, type, strikePrice) { }

        private void Set(string stockSymbol, int expirationYear, int expirationMonth, int expirationDay, OptionType type, double strikePrice)
        {
            if (expirationYear < 0)
            {
                throw new IllegalOptionQueryException("the option expiration year must be greater than 0");
            }

            if (expirationMonth < 0 || expirationMonth > 12)
            {
                throw new IllegalOptionQueryException("the option expiration month must be between 1 and 12 (inclusive)");
            }

            if (expirationDay < 0 || expirationDay > 31)
            {
                throw new IllegalOptionQueryException("the expiration day must be between 1 and 31 (inclusive)");
            }

            if (strikePrice <= 0)
            {
                throw new IllegalOptionQueryException("the strike price must be greater than 0");
            }

            expirationYear = expirationYear < 100 ? expirationYear + 2000 : expirationYear;
            var expiration = new DateTime(expirationYear, expirationMonth, expirationDay);
            if (DateTime.Now > expiration)
            {
                throw new IllegalOptionQueryException("the requested option expired on {0}", expiration.ToString("dd/MM/yyyy"));
            }

            StockSymbol = stockSymbol;
            ExpirationYear = expirationYear;
            ExpirationMonth = expirationMonth;
            ExpirationDay = expirationDay;
            Type = type;
            StrikePrice = strikePrice;
        }
    }
}
