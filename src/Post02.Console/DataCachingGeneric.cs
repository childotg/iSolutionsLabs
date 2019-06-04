using System;
using System.Collections.Generic;
using System.Runtime.Caching;
using System.Text;

namespace Post02.Console
{
    public class DataCaching<T> : IDataService where T : IDataService, new()
    {
        private T service;
        private MemoryCache cache = MemoryCache.Default;
        public DataCaching(T service)
        {
            this.service = service;
        }

        public Order[] GetOrdersFor(int customer)
        {
            var key = $"GetOrdersFor_{customer}";
            return GetOrAdd<Order[]>(key,
                () => service.GetOrdersFor(customer));
        }

        public Order GetOrder(int id)
        {
            var key = $"GetOrder_{id}";
            return GetOrAdd<Order>(key,
                () => service.GetOrder(id));
        }



        private K GetOrAdd<K>(string key, Func<K> eval)
        {
            var cachedItem = cache.Get(key);
            if (cachedItem != null) return (K)cachedItem;
            else
            {
                var result = eval();
                cache.Set(key, result,
                    new CacheItemPolicy()
                    {
                        SlidingExpiration = TimeSpan.FromSeconds(10)
                    });
                return result;
            }
        }


    }

}
