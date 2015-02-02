
namespace TradeKingWrapper
{
    public class StockDetail : Arg 
    {
        public StockDetail(string detailedDescription, string description, string tag) : base(detailedDescription, description, tag) { }

        public StockDetail(Arg detail) : base(detail.DetailedDescription, detail.Description, detail.Tag) { }
    }
}
