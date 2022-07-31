using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Common.Models
{
    public class CustomerOrderDto
    {
        public string OrderName { get; set; }
        public DateTime Created { get; set; }
        public OrderStatusDto CurrentStatus { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
