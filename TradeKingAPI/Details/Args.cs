
namespace TradeKingWrapper
{
    public static class Args
    {
        private static StockDetails stockDetails;
        private static OptionDetails optionDetails;

        public static StockDetails Stock
        {
            get { return stockDetails ?? (stockDetails = new StockDetails()); }
        }

        public static OptionDetails Option
        {
            get { return optionDetails ?? (optionDetails = new OptionDetails()); }
        }
    }
}
