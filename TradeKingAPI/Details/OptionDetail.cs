
namespace TradeKingWrapper
{
    public class OptionDetail : Arg
    {
        public OptionDetail(string detailedDescription, string description, string tag) : base(detailedDescription, description, tag) { }

        public OptionDetail(Arg detail) : base(detail.DetailedDescription, detail.Description, detail.Tag) { }
    }
}
