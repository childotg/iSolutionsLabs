using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Post02.Console
{
    public class DAL : IDataService
    {
        private Func<MyEntities> contextFactory = null;
        public DAL(Func<MyEntities> contextFactory)
        {
            this.contextFactory = contextFactory;
        }
        public Order GetOrder(int id)
        {
            return contextFactory().Orders
                .FirstOrDefault(p => p.ID == id);
        }
        public Order[] GetOrdersFor(int customer)
        {
            return contextFactory().Orders
                .Where(p => p.CustomerID == customer).ToArray();
        }
    }


}
