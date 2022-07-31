using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.DB.DatabaseModels
{
    public class DBNewOrder
    {
        public string Name { get; set; }
        public int OrderStatusId { get; set; }
        public int CustomerId { get; set; }
    }
}
