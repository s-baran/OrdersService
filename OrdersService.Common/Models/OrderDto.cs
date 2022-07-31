using System;
using System.Collections.Generic;

namespace OrdersService.Common.Models
{
    public class OrderDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public OrderStatusDto OrderStatus { get; set; }
        public DateTime CreationDate { get; set; } 
    }
}
