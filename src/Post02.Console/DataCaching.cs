//using System;
//using System.Collections.Generic;
//using System.Runtime.Caching;
//using System.Text;

//namespace Post02.Console
//{
//    public class DataCaching : IDataService
//    {
//        private IDataService service;
//        private MemoryCache cache = MemoryCache.Default;
//        public DataCaching(IDataService service)
//        {
//            this.service = service;
//        }
//        public Order[] GetOrdersFor(int customer)
//        {
//            var key = $"GetOrdersFor_{customer}";
//            var cachedItem = cache.Get(key);
//            if (cachedItem != null) return (Order[])cachedItem;
//            else
//            {
//                var result = service.GetOrdersFor(customer);
//                cache.Set($"GetOrdersFor_{customer}", result,
//                    new CacheItemPolicy()
//                    {
//                        SlidingExpiration = TimeSpan.FromSeconds(10)
//                    });
//                return result;
//            }
//        }
//    }

//}
