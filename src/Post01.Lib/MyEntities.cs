using System.Collections.Generic;

namespace Post01.Lib
{
    internal class MyEntities
    {
        public IEnumerable<Order> Orders { get; set; }
        public MyEntities()
        {
        }
    }
}