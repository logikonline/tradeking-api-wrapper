using System;
using System.Collections.Generic;
using System.Linq;

namespace TradeKingWrapper
{
    public interface IQueryArgumentSupplier<T>
    {
        IEnumerable<T> All { get; }

        T FindByTag(string tag);
    }

    public class QueryArgumentSupplier<T> : IQueryArgumentSupplier<T> where T : IQueryArgument
    {
        private IEnumerable<T> all;

        public IEnumerable<T> All
        {
            get
            {
                if (all == null)
                {
                    // Get all fields of this class.
                    all = GetType().GetFields().Select(x => x.GetValue(this)).Cast<T>();
                }
                return all;
            }
        }

        public T FindByTag(string tag)
        {
            return All.FirstOrDefault(x => x.Tag.Equals(tag));
        }
    }

    internal static class SupplierFactory
    {
        internal static IQueryArgumentSupplier<T> GetSupplier<T>() where T : IQueryArgument
        {
            if (typeof(T) == typeof(StockDetail))
            {
                return (IQueryArgumentSupplier<T>)Args.Stock;
            }

            if (typeof(T) == typeof(OptionDetail))
            {
                return (IQueryArgumentSupplier<T>)Args.Option;
            }

            throw new Exception(string.Format("No supplier for type '{0}", typeof(T)));
        }
    }
}
