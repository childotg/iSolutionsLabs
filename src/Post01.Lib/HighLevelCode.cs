using System;
using System.Collections.Generic;
using System.Text;

namespace Post01.Lib
{
    class HighLevelCode
    {
        private dynamic GetMyData(dynamic cache, dynamic db, string query)
        {
            var cachedItem = cache.Get(query);
            if (cachedItem != null) return cachedItem;
            else
            {
                var materialized = db.Query(query);
                cache.Set(query, materialized);
                return materialized;
            }
        }
    }
}
