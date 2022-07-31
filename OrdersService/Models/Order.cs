using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public OrderStatus OrderStatus { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
