using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Common.Models
{
    public class CreateOrderModelDto
    {
        public string OrderName { get; set; }
        public CustomerDto Customer { get; set; }
        public List<OrderItemDto> Items { get; set; }
    }
}
