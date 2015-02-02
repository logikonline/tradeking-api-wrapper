
namespace TradeKingWrapper
{
    internal class SharedDetails : QueryArgumentSupplier<Arg>
    {
        #region Recent Prices & Trends

        /// <summary>
        /// The current ask price of the stock.
        /// The ask price represents the lowest priced sell order that is currently available for the market.
        /// </summary>
        public StockDetail AskPrice = new StockDetail(
            detailedDescription: "The current ask price of the stock.",
            description: "Ask Price",
            tag: "ask");

        /// <summary>
        /// The time of the last ask.
        /// </summary>
        public StockDetail LastAskTime = new StockDetail(
            detailedDescription: "The time of the last ask.",
            description: "Last Ask Time",
            tag: "ask_time");

        /// <summary>
        /// The size of the last ask (in 100's).
        /// </summary>
        public StockDetail LastAskSize = new StockDetail(
            detailedDescription: "The size of the last ask.",
            description: "Last Ask Size",
            tag: "asksz");

        /// <summary>
        /// The current bid price of the stock. 
        /// The bid price represents the highest priced buy order that is currently available for the market.
        /// </summary>
        public Arg BidPrice = new Arg(
            detailedDescription: "The current bid price of the stock.",
            description: "Bid Price",
            tag: "bid");

        /// <summary>
        /// The time of the last bid.
        /// </summary>
        public Arg LastBidTime = new Arg(
            detailedDescription: "The time of the last bid.",
            description: "Last Bid Time",
            tag: "bid_time");

        /// <summary>
        /// The size of the last bid (in 100's).
        /// </summary>
        public Arg BidSize = new Arg(
            detailedDescription: "The size of the last bid.",
            description: "Last Bid Size",
            tag: "bidsz");

        /// <summary>
        /// The change in price of the stock for the current trading session.
        /// </summary>
        public Arg PriceChange = new Arg(
            detailedDescription: "The change in price of the stock for the current trading session.",
            description: "Price Change",
            tag: "chg");

        /// <summary>
        /// chg sign (e, u, d) as even, up, down
        /// </summary>
        public Arg PercentChangeSign = new Arg(
            detailedDescription: "",
            description: "",
            tag: "chg_sign");

        /// <summary>
        /// 
        /// </summary>
        public Arg PriceChangeTextFormat = new Arg(
            detailedDescription: "",
            description: "",
            tag: "chg_t");

        /// <summary>
        /// The change in price of the stock during the previous trading session.
        /// </summary>
        public Arg PriorPriceChange = new Arg(
            detailedDescription: "The change in price of the stock during the previous trading session.",
            description: "Prior Price Change",
            tag: "prchg");

        /// <summary>
        /// percentage change from prior day close
        /// </summary>
        public Arg PercentChange = new Arg(
            detailedDescription: "",
            description: "",
            tag: "pchg");

        /// <summary>
        /// prchg sign (e, u, d) as even, up, down
        /// </summary>
        public Arg PriorPercentChangeSign = new Arg(
            detailedDescription: "",
            description: "",
            tag: "pchg_sign");

        /// <summary>
        /// Tick direction from prior trade - (e, u, d)
        /// </summary>
        public Arg TradeTick = new Arg(
            detailedDescription: "",
            description: "",
            tag: "tradetick");

        /// <summary>
        /// The last trade price (a.k.a. the market price, or the price at which the last trade occured).
        /// The last price will move back and forth between the bid and ask prices during a trading session.
        /// </summary>
        public Arg LastTradePrice = new Arg(
            detailedDescription: "The last trade price of the stock.",
            description: "Last Trace Price",
            tag: "last");

        /// <summary>
        /// The price trend of the last 10 trades.
        /// </summary>
        public Arg PriceTrend = new Arg(
            detailedDescription: "The price trend of the last 10 trades.",
            description: "Trade Price Trend",
            tag: "trend");

        #endregion

        #region Volume

        /// <summary>
        /// The number (volume) of shares traded in the latest trading session.
        /// </summary>
        public Arg Volume = new Arg(
            detailedDescription: "The number of shares traded for the latest trading session.",
            description: "Volume",
            tag: "vl");

        /// <summary>
        /// 
        /// </summary>
        public Arg SessionVolume = new Arg(
            detailedDescription: "",
            description: "",
            tag: "sesn_vl");

        /// <summary>
        /// The total number (volume) of shares traded in the previous trading session.
        /// </summary>
        public Arg PriorVolume = new Arg(
            detailedDescription: "The total number of shares traded in the previous trading sessions.",
            description: "Previous Volume",
            tag: "pvol");

        /// <summary>
        /// The cumulative price of all share bought dividied by the number of shares traded for the latest 
        /// trading session. The theory is that if the price of a buy trade is lower than the volume 
        /// weight average price, then that is an indication of a good trdae.
        /// </summary>
        public Arg VolumeWeightedAveragePrice = new Arg(
            detailedDescription: "The cumulative price of all shares bought divided by the number of shares traded for the latest trading session.",
            description: "Volume Weighted Average",
            tag: "vwap");

        /// <summary>
        /// The number of shares (volume) of the last trade.
        /// </summary>
        public Arg VolumeOfLastTrade = new Arg(
            detailedDescription: "The volume of the last trade",
            description: "Last Trade Volume",
            tag: "incr_vl");

        /// <summary>
        /// The number of trades since the opening of the latest trading session.
        /// </summary>
        public Arg TradesSinceOpen = new Arg(
            detailedDescription: "The number of trades since the opening of the latest trading session.",
            description: "Trades Since Open",
            tag: "tr_num");

        /// <summary>
        /// Total dollar value of shares traded today.
        /// </summary>
        public Arg DollarValue = new Arg(
            detailedDescription: "",
            description: "",
            tag: "dollar_value");

        #endregion

        #region Opening And Closing Prices

        /// <summary>
        /// The opening price for the latest trading session.
        /// </summary>
        public Arg OpenPrice = new Arg(
            detailedDescription: "The opening price for the latest trading session.",
            description: "Open Price",
            tag: "opn");

        /// <summary>
        /// The opening price for the previous trading session.
        /// </summary>
        public Arg PriorOpenPrice = new Arg(
            detailedDescription: "The opening price for the previous trading session.",
            description: "Prior Open Price",
            tag: "popn");

        /// <summary>
        /// The closing price for the latest trading session.
        /// </summary>
        public Arg ClosePrice = new Arg(
            detailedDescription: "The closing price for the latest trading session.",
            description: "Close Price",
            tag: "cl");

        /// <summary>
        /// The closing price for the previous trading session
        /// </summary>
        public Arg PriorClosePrice = new Arg(
            detailedDescription: "The closing price for the previous trading session",
            description: "Prior Close Price",
            tag: "pcls");

        #endregion
    }
}
