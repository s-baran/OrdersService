using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.DB.DatabaseModels
{
    public class DBOrderDetails
    {
        public List<DBOrderItem> Items { get; set; }
        public DBCustomer CustomerDetails { get; set; }
    }
}
