using System;
using System.Collections.Generic;

namespace OrdersService.Common.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public List<Item> Items { get; set; }
    }
}
