
namespace TradeKingWrapper
{
    /// <summary>
    /// A piece of data that can be queried about a stock or option using the TradeKing financial API.
    /// </summary>
    public class Arg : IQueryArgument
    {
        public string DetailedDescription { get; private set; }
        public string Description { get; private set; }
        public string Tag { get; private set; }

        internal Arg(string detailedDescription, string description, string tag)
        {
            DetailedDescription = detailedDescription;
            Description = description;
            Tag = tag;
        }
    }
}
