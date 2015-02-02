using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace TradeKingWrapper
{
    /// <summary>
    /// Performs calls to the TradeKing financial API.
    /// </summary>
    public class TradeKingAPI
    {
        /// <summary>
        /// The consumer key.
        /// </summary>
        public string ConsumerKey { get; private set; }

        /// <summary>
        /// The consumer secret.
        /// </summary>
        public string ConsumerSecret { get; private set; }

        /// <summary>
        /// The authentication token.
        /// </summary>
        public string AuthToken { get; private set; }

        /// <summary>
        /// The authentication token secret.
        /// </summary>
        public string AuthTokenSecret { get; private set; }

        public TradeKingAPI(string consumerKey, string consumerSecret, string authToken, string authTokenSecret)
        {
            ValidateKey(consumerKey, "consumerKey");
            ValidateKey(consumerSecret, "consumerSecret");
            ValidateKey(authToken, "authToken");
            ValidateKey(authTokenSecret, "authTokenSecret");

            ConsumerKey = consumerKey;
            ConsumerSecret = consumerSecret;
            AuthToken = authToken;
            AuthTokenSecret = authTokenSecret;
        }

        private void ValidateKey(string key, string keyName)
        {
            if (key == null)
            {
                throw new ArgumentNullException(keyName);
            }

            if (!Regex.Match(key, "[a-zA-Z0-9]{40}").Success)
            {
                throw new ArgumentException(string.Format("{0} is invalid: must be 40 consecutive alpha-numeric characters", keyName));
            }
        }

        public StockQueryResult Execute(StockQuery query)
        {
            if (query == null)
            {
                throw new ArgumentNullException("query");
            }

            var responseText = Execute(query.QueryUri);
            ThrowIfError(responseText);
            return new StockQueryResult(responseText);
        }

        public OptionQueryResult Execute(OptionQuery query)
        {
            if (query == null)
            {
                throw new ArgumentNullException("query");
            }

            var responseText = Execute(query.QueryUri);
            ThrowIfError(responseText);
            return new OptionQueryResult(responseText);
        }

        public string Execute(string operation, Dictionary<string, string> parameters)
        {
            if (string.IsNullOrWhiteSpace(operation))
            {
                throw new ArgumentException("operation");
            }

            if (parameters == null)
            {
                throw new ArgumentNullException("parameters");
            }

            if (parameters.Keys.Count == 0)
            {
                throw new ArgumentException("there must be at least 1 parameter");
            }

            var query = new StringBuilder();
            query.Append("https://api.tradeking.com/v1");
            query.Append(operation);
            query.Append("?");
            foreach (var parameter in parameters.Keys)
            {
                query.Append(string.Format("{0}={1}", parameter, parameters[parameter]));
            }

            return Execute(query.ToString());
        }

        public string Execute(string queryUri)
        {
            if (string.IsNullOrWhiteSpace(queryUri))
            {
                throw new ArgumentException("queryUri");
            }

            var uri = new Uri(queryUri);

            var o = new OAuthBase();
            var nonce = o.GenerateNonce();
            var timestamp = o.GenerateTimeStamp();

            string normalizedUrl;
            string normalizedParameters;
            var signature = HttpUtility.UrlEncode(
                o.GenerateSignature(uri, ConsumerKey, ConsumerSecret, AuthToken, AuthTokenSecret, "GET",
                                    timestamp, nonce, out normalizedUrl, out normalizedParameters));

            uri = new Uri(string.Concat(normalizedUrl, "?", normalizedParameters, "&oauth_signature=", signature));

            using (var httpClient = new WebClient())
            {
                return httpClient.DownloadString(uri.AbsoluteUri);
            }
        }

        private void ThrowIfError(string responseText)
        {
            JObject root;
            try
            {
                root = JObject.Parse(responseText);
            }
            catch(Exception ex)
            {
                throw new TradeKingQueryException("Could not parse query response: {0}. The response text was: {1}", ex.Message, responseText);
            }

            var response = root["response"];
            if (response == null)
            {
                throw new TradeKingQueryException("No 'response' field at root of query response: {0}", responseText);
            }

            var type = response["type"];
            if (type != null && type.ToString().Equals("Error"))
            {
                var error = response["name"].ToString();
                var description = response["description"].ToString();
                throw new TradeKingQueryException("{0}: {1}", error, description);
            }
        }
    }
}
