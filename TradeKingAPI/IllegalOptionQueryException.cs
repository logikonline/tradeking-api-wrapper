using System;
using System.Runtime.Serialization;

namespace TradeKingWrapper
{
    public class IllegalOptionQueryException : Exception
    {
        public IllegalOptionQueryException() { }
        public IllegalOptionQueryException(string message) : base(message) { }
        public IllegalOptionQueryException(string format, params object[] args) : base(string.Format(format, args)) { }
        public IllegalOptionQueryException(string message, System.Exception inner) : base(message, inner) { }
        public IllegalOptionQueryException(SerializationInfo info, StreamingContext context) : base(info, context) { }
    }
}
