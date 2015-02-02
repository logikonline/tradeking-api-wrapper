using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace TradeKingWrapper
{
    public class QuoteQueryResult<T> where T : IQueryArgument
    {
        private Dictionary<T, string> details;

        /// <summary>
        /// The full json response of the query.
        /// </summary>
        public string FullResponse { get; private set; }

        /// <summary>
        /// The part of the response that contains the requested quote data.
        /// </summary>
        public string QuoteResponse { get; private set; }

        /// <summary>
        /// Gets the quote response as a JObject.
        /// </summary>
        public JObject JQuoteResponse
        {
            get
            {
                return JObject.Parse(QuoteResponse.ToString());
            }
        }

        public string this[T key]
        {
            get
            {
                if (details.ContainsKey(key))
                {
                    return details[key];
                }

                return null;
            }
        }

        internal QuoteQueryResult(string json)
        {
            FullResponse = json;
            details = new Dictionary<T, string>();
            var root = JObject.Parse(json);
            var response = root["response"];
            var id = response["id"];
            var quote = response["quotes"]["quote"];
            QuoteResponse = quote.ToString();

            foreach(var property in quote)
            {
                var jproperty = property as JProperty;
                if (jproperty != null)
                {
                    var supplier = SupplierFactory.GetSupplier<T>();
                    var detail = supplier.FindByTag(jproperty.Name);                  
                    if (detail != null)
                    {
                        details[detail] = jproperty.Value.ToString();
                    }
                }      
            }
        }
    }

    public class OptionQueryResult : QuoteQueryResult<OptionDetail>
    {
        public OptionQueryResult(string json) : base(json) { }
    }

    public class StockQueryResult : QuoteQueryResult<StockDetail>
    {
        public StockQueryResult(string json) : base(json) { }
    }
}
