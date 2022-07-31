using System;
using System.Collections.Generic;

namespace OrdersService.Models
{
    public class OrderDetails : Order
    {
        public OrderDetails()
        {

        }
        public OrderDetails(Order order)
        {
            Type type = order.GetType();
            foreach (var propertyInfo in type.GetProperties())
            {
                propertyInfo.SetValue(this, propertyInfo.GetValue(order));
            }
        }

        public List<Item> Items { get; set; }
        public CustomerDetails Customer { get; set; }
    }
}
