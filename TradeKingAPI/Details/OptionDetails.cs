
namespace TradeKingWrapper
{
    /// <summary>
    /// A listing of every <see cref="OptionDetail"/>.
    /// See https://developers.tradeking.com/documentation/market-ext-quotes-get-post
    /// </summary>
    public class OptionDetails : QueryArgumentSupplier<OptionDetail>
    {
        // TODO: Finish the option details.
        private static SharedDetails shared = new SharedDetails();

        #region Recent Prices & Trends

        /// <summary>
        /// The current ask price of the stock.
        /// The ask price represents the lowest priced sell order that is currently available for the market.
        /// </summary>
        public OptionDetail AskPrice = new OptionDetail(shared.AskPrice);

        /// <summary>
        /// The time of the last ask.
        /// </summary>
        public OptionDetail LastAskTime = new OptionDetail(shared.LastAskTime);

        /// <summary>
        /// The size of the last ask (in 100's).
        /// </summary>
        public OptionDetail LastAskSize = new OptionDetail(shared.LastAskSize);

        /// <summary>
        /// The current bid price of the stock. 
        /// The bid price represents the highest priced buy order that is currently available for the market.
        /// </summary>
        public OptionDetail BidPrice = new OptionDetail(shared.BidPrice);

        /// <summary>
        /// The time of the last bid.
        /// </summary>
        public OptionDetail LastBidTime = new OptionDetail(shared.LastBidTime);

        /// <summary>
        /// The size of the last bid (in 100's).
        /// </summary>
        public OptionDetail BidSize = new OptionDetail(shared.BidSize);

        /// <summary>
        /// The change in price of the stock for the current trading session.
        /// </summary>
        public OptionDetail PriceChange = new OptionDetail(shared.PriceChange);

        /// <summary>
        /// 
        /// </summary>
        public OptionDetail PriceChangeTextFormat = new OptionDetail(shared.PriceChangeTextFormat);

        /// <summary>
        /// The change in price of the stock during the previous trading session.
        /// </summary>
        public OptionDetail PriorPriceChange = new OptionDetail(shared.PriorPriceChange);

        /// <summary>
        /// percentage change from prior day close
        /// </summary>
        public OptionDetail PercentChange = new OptionDetail(shared.PercentChange);

        /// <summary>
        /// chg sign (e, u, d) as even, up, down
        /// </summary>
        public OptionDetail PercentChangeSign = new OptionDetail(shared.PercentChangeSign);

        /// <summary>
        /// prchg sign (e, u, d) as even, up, down
        /// </summary>
        public OptionDetail PriorPercentChangeSign = new OptionDetail(shared.PriorPercentChangeSign);

        /// <summary>
        /// Tick direction from prior trade - (e, u, d)
        /// </summary>
        public OptionDetail TradeTick = new OptionDetail(shared.TradeTick);

        /// <summary>
        /// The last trade price (a.k.a. the market price, or the price at which the last trade occured).
        /// The last price will move back and forth between the bid and ask prices during a trading session.
        /// </summary>
        public OptionDetail LastTradePrice = new OptionDetail(shared.LastTradePrice);

        /// <summary>
        /// The price trend of the last 10 trades.
        /// </summary>
        public OptionDetail PriceTrend = new OptionDetail(shared.PriceTrend);

        #endregion

        #region Volume

        /// <summary>
        /// The number (volume) of shares traded in the latest trading session.
        /// </summary>
        public OptionDetail Volume = new OptionDetail(shared.Volume);

        /// <summary>
        /// 
        /// </summary>
        public OptionDetail SessionVolume = new OptionDetail(shared.SessionVolume);

        /// <summary>
        /// The total number (volume) of shares traded in the previous trading session.
        /// </summary>
        public OptionDetail PriorVolume = new OptionDetail(shared.PriorVolume);

        /// <summary>
        /// The cumulative price of all share bought dividied by the number of shares traded for the latest 
        /// trading session. The theory is that if the price of a buy trade is lower than the volume 
        /// weight average price, then that is an indication of a good trdae.
        /// </summary>
        public OptionDetail VolumeWeightedAveragePrice = new OptionDetail(shared.VolumeWeightedAveragePrice);

        /// <summary>
        /// The number of shares (volume) of the last trade.
        /// </summary>
        public OptionDetail VolumeOfLastTrade = new OptionDetail(shared.VolumeOfLastTrade);

        /// <summary>
        /// The average daily volume of the stock over the past 21 trade days.
        /// </summary>
        public OptionDetail AverageDailyVolume21 = new OptionDetail(
            detailedDescription: "The average daily volume of the stock over the past 21 trade days.",
            description: "Average Daily Volume - 21 days",
            tag: "adv_21");

        /// <summary>
        /// The average daily volume of the stock over the past 30 trade days.
        /// </summary>
        public OptionDetail AverageDailyVolume30 = new OptionDetail(
            detailedDescription: "The average daily volume of the stock over the past 30 trade days.",
            description: "Average Daily Volume - 30 days",
            tag: "adv_30");

        /// <summary>
        /// The average daily volume of the stock over the past 90 trade days.
        /// </summary>
        public OptionDetail AverageDailyVolume90 = new OptionDetail(
            detailedDescription: "The average daily volume of the stock over the past 90 trade days.",
            description: "Average Daily Volume - 90 days",
            tag: "adv_90");

        /// <summary>
        /// The number of trades since the opening of the latest trading session.
        /// </summary>
        public OptionDetail TradesSinceOpen = new OptionDetail(shared.TradesSinceOpen);

        /// <summary>
        /// Total dollar value of shares traded today.
        /// </summary>
        public OptionDetail DollarValue = new OptionDetail(shared.DollarValue);

        #endregion

        #region Opening And Closing Prices

        /// <summary>
        /// The opening price for the latest trading session.
        /// </summary>
        public OptionDetail OpenPrice = new OptionDetail(shared.OpenPrice);

        /// <summary>
        /// The opening price for the previous trading session.
        /// </summary>
        public OptionDetail PriorOpenPrice = new OptionDetail(shared.PriorOpenPrice);

        /// <summary>
        /// The closing price for the latest trading session.
        /// </summary>
        public OptionDetail ClosePrice = new OptionDetail(shared.ClosePrice);

        /// <summary>
        /// The closing price for the previous trading session
        /// </summary>
        public OptionDetail PriorClosePrice = new OptionDetail(shared.PriorClosePrice);

        #endregion
    }
}
