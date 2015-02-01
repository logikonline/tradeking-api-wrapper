# tradeking-api-wrapper
A heavy wrapper for TradeKing API calls in C#

Construct the API object:

    const string consumerKey = "myConsumerKey";
    const string consumerSecret = "myConsumerSecret";
    const string oAuthToken = "myOAuthToken";
    const string oAuthSecretToken = "myOAuthSecretToken";
    
    // Construct the API.
    var api = new TradeKingAPI(consumerKey, consumerSecret, oAuthToken, oAuthSecretToken);

Query information about a stock:

    // Construct the stock query.
    var stockQuery = new StockQuery("MSFT");
    
    // Add the information we want to query about the stock.
    stockQuery.Add(Args.Stock.Symbol, Args.Stock.DailyHigh, Args.Stock.ClosePrice);
    
    // Execute the query against the TradeKing API.
    var result = api.Execute(stockQuery);
    
    // Print out one of the queried arguments.
    Console.WriteLine("Daily high: {0}", result[Args.Stock.DailyHigh]);
    
Query information about an option:

    // Construct the option query:
    var optionQuery = new OptionQuery(
      symbol: "MSFT", 
      expiration: new DateTime(2015, 3, 20),
      type: OptionType.Call,
      strikePrice: 45);
    
    // Add the information we want to query about the option.
    stockQuery.Add(Args.Option.Symbol, Args.Option.ImpliedVolatility, Args.Option.Delta);
    
    // Execute the query against the TradeKing API.
    var result = api.Execute(optionQuery);
    
    // Print out one of the queried arguments.
    Console.WriteLine("Implied volatility: {0}", result[Args.Option.ImpliedVolatility]);
  
