using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Caching;
using System.Text;

namespace Post01.Lib
{
    public class DAL_V2
    {
        private MemoryCache cache = MemoryCache.Default;
        public Order[] GetOrdersFor(int customer)
        {
            var cachedItem = cache.Get($"GetOrdersFor_{customer}");
            if (cachedItem != null) return (Order[])cachedItem;
            else
            {
                var db = new MyEntities();
                var result = db.Orders
                            .Where(p => p.CustomerID == customer)
                            .ToArray();
                cache.Set($"GetOrdersFor_{customer}", result,
                    new CacheItemPolicy()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(10)
                    });
                return result;
            }

        }
    }
}
