
namespace TradeKingWrapper
{
    /// <summary>
    /// A listing of every <see cref="StockDetail"/>.
    /// See https://developers.tradeking.com/documentation/market-ext-quotes-get-post
    /// </summary>
    public class StockDetails : QueryArgumentSupplier<StockDetail>
    {
        private static readonly SharedDetails shared = new SharedDetails();

        #region Average Daily Prices

        /// <summary>
        /// The average daily price of the stock over the past 100 trade days.
        /// </summary>
        public StockDetail AverageDailyPrice100 = new StockDetail(
            detailedDescription: "The average daily price of the stock over the past 100 trade days.",
            description: "Average Daily Price - 100 days",
            tag: "adp_100");

        /// <summary>
        /// The prior average daily price of the stock over the past 100 trade days.
        /// </summary>
        public StockDetail PriorAverageDailyPrice100 = new StockDetail(
            detailedDescription: "The prior average daily price of the stock over the past 100 trade days.",
            description: "Prior Average Daily Price - 100 days",
            tag: "pr_adp_100");

        /// <summary>
        /// The average daily price of the stock over the past 200 trade days.
        /// </summary>
        public StockDetail AverageDailyPrice200 = new StockDetail(
            detailedDescription: "The average daily price of the stock over the past 200 trade days.",
            description: "Average Daily Price - 200 days",
            tag: "adp_200");

        /// <summary>
        /// The prior average daily price of the stock over the past 100 trade days.
        /// </summary>
        public StockDetail PriorAverageDailyPrice200 = new StockDetail(
            detailedDescription: "The prior average daily price of the stock over the past 100 trade days.",
            description: "Prior Average Daily Price - 200 days",
            tag: "pr_adp_200");

        /// <summary>
        /// The average daily price of the stock over the past 50 trade days.
        /// </summary>
        public StockDetail AverageDailyPrice50 = new StockDetail(
            detailedDescription: "The average daily price of the stock over the past 50 trade days.",
            description: "Average Daily Price - 50 days",
            tag: "adp_50");

        /// <summary>
        /// The prior average daily price of the stock over the past 50 trade days.
        /// </summary>
        public StockDetail PriorAverageDailyPrice50 = new StockDetail(
            detailedDescription: "The prior average daily price of the stock over the past 50 trade days.",
            description: "Prior Average Daily Price - 50 days",
            tag: "pr_adp_50");

        #endregion

        #region Recent Prices & Trends

        /// <summary>
        /// The current ask price of the stock.
        /// The ask price represents the lowest priced sell order that is currently available for the market.
        /// </summary>
        /// <summary>
        /// <see cref="SharedDetails.AskPrice"/>
        /// </summary>
        public StockDetail AskPrice = new StockDetail(shared.AskPrice);

        /// <summary>
        /// The time of the last ask.
        /// </summary>
        public StockDetail LastAskTime = new StockDetail(shared.LastAskTime);

        /// <summary>
        /// The size of the last ask (in 100's).
        /// </summary>
        public StockDetail LastAskSize = new StockDetail(shared.LastAskSize);

        /// <summary>
        /// The current bid price of the stock. 
        /// The bid price represents the highest priced buy order that is currently available for the market.
        /// </summary>
        public StockDetail BidPrice = new StockDetail(shared.BidPrice);

        /// <summary>
        /// The time of the last bid.
        /// </summary>
        public StockDetail LastBidTime = new StockDetail(shared.LastBidTime);

        /// <summary>
        /// The size of the last bid (in 100's).
        /// </summary>
        public StockDetail BidSize = new StockDetail(shared.BidSize);

        /// <summary>
        /// The tick direction since last bid.
        /// </summary>
        public StockDetail BidTickDirection = new StockDetail(
            detailedDescription: "The tick direction since last bid.",
            description: "Bid Tick Direction",
            tag: "bidtick");

        /// <summary>
        /// The change in price of the stock for the current trading session.
        /// </summary>
        public StockDetail PriceChange = new StockDetail(shared.PriceChange);

        /// <summary>
        /// 
        /// </summary>
        public StockDetail PriceChangeTextFormat = new StockDetail(shared.PriceChangeTextFormat);

        /// <summary>
        /// The change in price of the stock during the previous trading session.
        /// </summary>
        public StockDetail PriorPriceChange = new StockDetail(shared.PriorPriceChange);

        /// <summary>
        /// percentage change from prior day close
        /// </summary>
        public StockDetail PercentChange = new StockDetail(shared.PercentChange);

        /// <summary>
        /// chg sign (e, u, d) as even, up, down
        /// </summary>
        public StockDetail PercentChangeSign = new StockDetail(shared.PercentChangeSign);

        /// <summary>
        /// prchg sign (e, u, d) as even, up, down
        /// </summary>
        public StockDetail PriorPercentChangeSign = new StockDetail(shared.PriorPercentChangeSign);

        /// <summary>
        /// Tick direction from prior trade - (e, u, d)
        /// </summary>
        public StockDetail TradeTick = new StockDetail(shared.TradeTick);

        /// <summary>
        /// The last trade price (a.k.a. the market price, or the price at which the last trade occured).
        /// The last price will move back and forth between the bid and ask prices during a trading session.
        /// </summary>
        public StockDetail LastTradePrice = new StockDetail(shared.LastTradePrice);

        /// <summary>
        /// The price trend of the last 10 trades.
        /// </summary>
        public StockDetail PriceTrend = new StockDetail(shared.PriceTrend);

        #endregion

        #region Volume

        /// <summary>
        /// The number (volume) of shares traded in the latest trading session.
        /// </summary>
        public StockDetail Volume = new StockDetail(shared.Volume);

        /// <summary>
        /// 
        /// </summary>
        public StockDetail SessionVolume = new StockDetail(shared.SessionVolume);

        /// <summary>
        /// The total number (volume) of shares traded in the previous trading session.
        /// </summary>
        public StockDetail PriorVolume = new StockDetail(shared.PriorVolume);

        /// <summary>
        /// The cumulative price of all share bought dividied by the number of shares traded for the latest 
        /// trading session. The theory is that if the price of a buy trade is lower than the volume 
        /// weight average price, then that is an indication of a good trdae.
        /// </summary>
        public StockDetail VolumeWeightedAveragePrice = new StockDetail(shared.VolumeWeightedAveragePrice);

        /// <summary>
        /// The number of shares (volume) of the last trade.
        /// </summary>
        public StockDetail VolumeOfLastTrade = new StockDetail(shared.VolumeOfLastTrade);

        /// <summary>
        /// The average daily volume of the stock over the past 21 trade days.
        /// </summary>
        public StockDetail AverageDailyVolume21 = new StockDetail(
            detailedDescription: "The average daily volume of the stock over the past 21 trade days.",
            description: "Average Daily Volume - 21 days",
            tag: "adv_21");

        /// <summary>
        /// The average daily volume of the stock over the past 30 trade days.
        /// </summary>
        public StockDetail AverageDailyVolume30 = new StockDetail(
            detailedDescription: "The average daily volume of the stock over the past 30 trade days.",
            description: "Average Daily Volume - 30 days",
            tag: "adv_30");

        /// <summary>
        /// The average daily volume of the stock over the past 90 trade days.
        /// </summary>
        public StockDetail AverageDailyVolume90 = new StockDetail(
            detailedDescription: "The average daily volume of the stock over the past 90 trade days.",
            description: "Average Daily Volume - 90 days",
            tag: "adv_90");

        /// <summary>
        /// The number of trades since the opening of the latest trading session.
        /// </summary>
        public StockDetail TradesSinceOpen = new StockDetail(shared.TradesSinceOpen);

        /// <summary>
        /// Total dollar value of shares traded in the latest trading session.
        /// </summary>
        public StockDetail DollarValue = new StockDetail(shared.DollarValue);

        #endregion

        #region Opening And Closing Prices

        /// <summary>
        /// The opening price for the latest trading session.
        /// </summary>
        public StockDetail OpenPrice = new StockDetail(shared.OpenPrice);

        /// <summary>
        /// The opening price for the previous trading session.
        /// </summary>
        public StockDetail PriorOpenPrice = new StockDetail(shared.PriorOpenPrice);

        /// <summary>
        /// The closing price for the latest trading session.
        /// </summary>
        public StockDetail ClosePrice = new StockDetail(shared.ClosePrice);

        /// <summary>
        /// The closing price for the previous trading session
        /// </summary>
        public StockDetail PriorClosePrice = new StockDetail(shared.PriorClosePrice);

        #endregion

        #region Dividends

        /// <summary>
        /// 
        /// </summary>
        public StockDetail Div = new StockDetail(
            detailedDescription: "",
            description: "",
            tag: "div");

        /// <summary>
        /// 
        /// </summary>
        public StockDetail DixExDate = new StockDetail(
            detailedDescription: "",
            description: "",
            tag: "divexdate");

        /// <summary>
        /// 
        /// </summary>
        public StockDetail DivFreq = new StockDetail(
            detailedDescription: "",
            description: "",
            tag: "divfreq");

        /// <summary>
        /// 
        /// </summary>
        public StockDetail DivPayDt = new StockDetail(
            detailedDescription: "",
            description: "",
            tag: "divpaydt");

        /// <summary>
        /// 
        /// </summary>
        public StockDetail Iad = new StockDetail(
            detailedDescription: "",
            description: "",
            tag: "iad");

        /// <summary>
        /// The dividend yield as a percentage
        /// </summary>
        public StockDetail Yield = new StockDetail(
            detailedDescription: "",
            description: "",
            tag: "yield");

        #endregion

        #region Highs And Lows

        /// <summary>
        /// The high trade price of the latest trading session.
        /// </summary>
        public StockDetail DailyHigh = new StockDetail(
            detailedDescription: "The high trade price of the latest trading session.",
            description: "Daily High",
            tag: "hi");

        /// <summary>
        /// The highest trade price of the previous trading session.
        /// </summary>
        public StockDetail PriorDailyHigh = new StockDetail(
            detailedDescription: "The highest trade price of the previous trading session.",
            description: "Prior Daily High",
            tag: "phi");

        /// <summary>
        /// The low trade price of the latest trading session.
        /// </summary>
        public StockDetail DailyLow = new StockDetail(
            detailedDescription: "The low trade price of the latest trading session.",
            description: "Daily Low",
            tag: "lo");

        /// <summary>
        /// The lowest trade price of the previous trading session.
        /// </summary>
        public StockDetail PriorDailyLow = new StockDetail(
            detailedDescription: "The lowest trade price of the previous trading session.",
            description: "Prior Daily Low",
            tag: "plo");

        /// <summary>
        /// The 52-week high price of the stock.
        /// </summary>
        public StockDetail YearlyHigh = new StockDetail(
            detailedDescription: "The 52-week high price of the stock.",
            description: "Yearly High",
            tag: "wk52hi");

        /// <summary>
        /// The date the 52-week high price occurred.
        /// </summary>
        public StockDetail YearlyHighDate = new StockDetail(
            detailedDescription: "The date the 52-week high price occurred.",
            description: "Yearly High Date",
            tag: "wk52hidate");

        /// <summary>
        /// The 52-week low price of the stock.
        /// </summary>
        public StockDetail YearlyLow = new StockDetail(
            detailedDescription: "The 52-week low price of the stock.",
            description: "Yearly Low",
            tag: "wk52lo");

        /// <summary>
        /// The date the 52-week low price occurred.
        /// </summary>
        public StockDetail YearlyLowDate = new StockDetail(
            detailedDescription: "The date the 52-week low price occurred.",
            description: "Yearly Low Date",
            tag: "wk52lodate");

        #endregion

        #region Metrics

        /// <summary>
        /// The one year volatility measure of the stock.
        /// </summary>
        public StockDetail YearlyVolatility = new StockDetail(
            detailedDescription: "The one year volatility measure of the stock.",
            description: "Yearly Volatility",
            tag: "volatility12");

        /// <summary>
        /// The number of outstanding shares. Shares outstanding are all the shares of 
        /// a corporation that have been authorized, issued and purchased by investors and are 
        /// held by them. They are distinguished from treasure shares, which are shares held by 
        /// the corporation itself and  have no exercisable rights.
        /// </summary>
        public StockDetail SharesOutstanding = new StockDetail(
            detailedDescription: "The number of outstanding shares.",
            description: "Number Of Outstanding Shares",
            tag: "sho");

        /// <summary>
        /// The price to earnings ratio (P/E) - a valuation ratio of a company's current share price
        /// compared to its per-share earnings. In general, a high P/E suggests that investors are
        /// expecting higher earnings growth in the future compared to companies with a lower P/E.
        /// </summary>
        public StockDetail PriceToEarningsRatio = new StockDetail(
            detailedDescription: "The price to earnings ration.",
            description: "Price To Earning Ratio",
            tag: "pe");

        /// <summary>
        /// The portion of a company's profit allocated to each outstanding share of stock.
        /// <para>&#160;</para>
        /// Earnings per share servers as an indicator of a company's profitability, and is 
        /// generally considered to be one of the single most important varaible in determining a share's price.
        /// </summary>
        public StockDetail EarningsPerShare = new StockDetail(
            detailedDescription: "",
            description: "Earnings Per Share",
            tag: "eps");

        /// <summary>
        /// The cost basis of the stock. The cost basis is the original value of the asset for tax 
        /// purposes, adjusted for stock splits, dividends and return of capital distributions.
        /// <para>&#160;</para>
        /// Using the correct tax basis is important especially if you reinvested dividends and capital 
        /// gains distributions instead of taking the earnings in cash. Reinvesting distributions increases 
        /// the tax basis of your investment, which you must account for in order to report a lower 
        /// capital gain (and therefore pay less tax). If you don't use the higher tax basis, you could 
        /// end up paying taxes twice on the reinvested distributions.
        /// </summary>
        public StockDetail CostBasis = new StockDetail(
            detailedDescription: "The original value of the asset for tax purposes, adjusted for stock splits, dividents and return of capital distributions.",
            description: "Cost Basis",
            tag: "basis");

        /// <summary>
        /// The beta coefficient of the stock. The beta value is a measure of the volatility, or systematic risk, of the
        /// stock in comparison to the market as a whole.
        /// <para>&#160;</para>
        /// Beta is calculated using regression analysis, and you can think of beta as the tendency of a security's returns to 
        /// respond to swings in the market. A beta of 1 indicates that the security's price will move with the market.
        /// A beta of less than 1 means that the security will be less volatile than the market. A beta of greater than 1 indicates 
        /// that the security's price will be more volatile than the market. For example, if a stock's beta is 1.2, 
        /// it's theoretically 20% more volatile than the market.
        /// <para>&#160;</para>
        /// Many utilities stocks have a beta of less than 1. Conversely, most high-tech, Nasdaq-based stocks have a beta of greater 
        /// than 1, offering the possibility of a higher rate of return, but also posing more risk.
        /// </summary>
        public StockDetail Beta = new StockDetail(
            detailedDescription: "The measure of the volatility, or systematic risk, of the stock in comparison to the market as a whole.",
            description: "Beta Coefficient",
            tag: "beta");

        #endregion

        #region Symbols

        /// <summary>
        /// The stock symbol.
        /// </summary>
        public StockDetail Symbol = new StockDetail(
            detailedDescription: "The stock symbol.",
            description: "Stock Symbol",
            tag: "symbol");

        /// <summary>
        /// The company name.
        /// </summary>
        public StockDetail CompanyName = new StockDetail(
            detailedDescription: "The company name.",
            description: "Company Name",
            tag: "name");

        /// <summary>
        /// The symbol of the exchange this stock is traded on.
        /// </summary>
        public StockDetail ExchangeSymbol = new StockDetail(
            detailedDescription: "The symbol of the exchange this stock is traded on.",
            description: "Exchance Symbol",
            tag: "exch");

        /// <summary>
        /// The name of the exchange this stock is traded on.
        /// </summary>
        public StockDetail ExchangeName = new StockDetail(
            detailedDescription: "The name of the exchange this stock is traded on.",
            description: "Exchange Name",
            tag: "exch_desc");

        /// <summary>
        /// The CUSIP number of the stock. A CUSIP number is an identification number
        /// assigned to all stocks and registered bonds.
        /// </summary>
        public StockDetail CusipNumber = new StockDetail(
            detailedDescription: "The CUSIP number of the stock.",
            description: "Cusip",
            tag: "cusip");

        #endregion

        #region Miscellaneous

        /// <summary>
        /// The book value price of the company.
        /// </summary>
        public StockDetail BookValue = new StockDetail(
            detailedDescription: "The book value price of the company.",
            description: "Book Value Price",
            tag: "prbook");

        /// <summary>
        /// The trade condition code - (H)alted or (R)esumed.
        /// </summary>
        public StockDetail TradingStatus = new StockDetail(
            detailedDescription: "The trade condition code (halted or resumed)",
            description: "Trading Status",
            tag: "tcond");

        /// <summary>
        /// The current timestamp.
        /// </summary>
        public StockDetail TimeStamp = new StockDetail(
            detailedDescription: "The current timestamp.",
            description: "Timestamp",
            tag: "timestamp");

        /// <summary>
        /// The date and time of the last trade.
        /// </summary>
        public StockDetail DateTime = new StockDetail(
            detailedDescription: "The date and time of the last trade.",
            description: "Last Trade Date And Time",
            tag: "datetime");

        /// <summary>
        /// The date of the last trade.
        /// </summary>
        public StockDetail LastTradeDate = new StockDetail(
            detailedDescription: "The date of the last trade.",
            description: "Last Trade Date",
            tag: "date");

        /// <summary>
        /// 
        /// </summary>
        public StockDetail PriorLastTradeDate = new StockDetail(
            detailedDescription: "",
            description: "",
            tag: "pr_date");

        /// <summary>
        /// 
        /// </summary>
        public StockDetail ConditionCode = new StockDetail(
            detailedDescription: "",
            description: "",
            tag: "qcond");

        /// <summary>
        /// Whether or not options are available for this stock.
        /// </summary>
        public StockDetail AreOptionsAvailable = new StockDetail(
            detailedDescription: "Whether or not options are available for this stock.",
            description: "Are Options Available",
            tag: "op_flag");

        /// <summary>
        /// The security class - "0" for stock and "1" for option. 
        /// </summary>
        public StockDetail SecurityClass = new StockDetail(
            detailedDescription: "The type of security.",
            description: "Security Class",
            tag: "secclass");

        /// <summary>
        /// The trading session as [pre, regular, &amp;, post].
        /// </summary>
        public StockDetail TradingSession = new StockDetail(
            detailedDescription: "The trading session as [pre, regular, &amp, post].",
            description: "Trading Session",
            tag: "sesn");

        #endregion
    }
}
