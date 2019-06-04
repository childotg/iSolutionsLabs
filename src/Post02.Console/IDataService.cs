using System;
using System.Collections.Generic;
using System.Text;

namespace Post02.Console
{
    public interface IDataService
    {
        Order[] GetOrdersFor(int customer);
        Order GetOrder(int id);

    }

}
