using System;
using System.Runtime.Serialization;

namespace TradeKingWrapper
{
    /// <summary>
    /// An exception thrown when there is an error executing a TradeKing query.
    /// </summary>
    [Serializable]
    public class TradeKingQueryException : Exception
    {
        public TradeKingQueryException() { }
        public TradeKingQueryException(string message) : base(message) { }
        public TradeKingQueryException(string format, params object[] args) : base(string.Format(format, args)) { }
        public TradeKingQueryException(string message, System.Exception inner) : base(message, inner) { }
        public TradeKingQueryException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
