using System;
using System.Collections.Generic;

namespace TradeKingWrapper
{
    /// <summary>
    /// Query base class for stock and option queries.
    /// </summary>
    /// <typeparam name="T">the query argument type</typeparam>
    public abstract class QuoteQuery<T> : IQuery where T : IQueryArgument
    {
        protected List<string> fields;

        protected QuoteQuery()
        {
            fields = new List<string>();
        }

        public abstract string QueryUri { get; }

        public IQuery Add(T flag)
        {
            var tag = flag.Tag;
            if (!fields.Contains(tag))
            {
                fields.Add(flag.Tag);
            }
            return this;
        }

        public IQuery Add(IEnumerable<T> flags)
        {
            if (flags == null)
            {
                throw new ArgumentNullException("flags");
            }

            foreach (var flag in flags)
            {
                Add(flag);
            }

            return this;
        }

        public IQuery Add(params T[] flags)
        {
            return Add(flags);
        }
    }
}
