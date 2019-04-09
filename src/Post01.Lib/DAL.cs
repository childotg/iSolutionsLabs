using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Post01.Lib
{
    public class DAL
    {
        public Order[] GetOrdersFor(int customer)
        {
            var db = new MyEntities();
            return db.Orders.Where(p => p.CustomerID == customer).ToArray();
        }
    }
}
