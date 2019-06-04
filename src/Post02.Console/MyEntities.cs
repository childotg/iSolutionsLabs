using System;
using System.Collections.Generic;
using System.Text;

namespace Post02.Console
{
    public class MyEntities
    {
        public IEnumerable<Order> Orders { get; set; }
        public MyEntities()
        {
        }
    }
}
