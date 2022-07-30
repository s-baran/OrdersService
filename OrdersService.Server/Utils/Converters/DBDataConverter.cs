using OrdersService.Common.Models;
using OrdersService.DB.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Server.Utils.Converters
{
    public static class DBDataConverter
    {
        public static DBOrder Convert(Order order)
        {
            DBOrder dBOrder = new DBOrder
            {
                Id = order.Id,
                Name = order.Name,
                Status = order.OrderStatus.ToString()
            };
            return dBOrder;
        }    
        public static Order Convert(DBOrder order)
        {
            Order dBOrder = new Order
            {
                Id = order.Id,
                Name = order.Name,
                OrderStatus = (OrderStatus)Enum.Parse(typeof(OrderStatus), order.Status),
                CreationDate = order.CreationTime.ToUniversalTime(),
            };
            return dBOrder;
        }
        public static List<Order> Convert(List<DBOrder> orders)
        {
            var list = new List<Order>();
            foreach (DBOrder order in orders)
            {
                list.Add(Convert(order));
            }

            return list;
        }

        internal static Customer Convert(DBCustomer customerDetails)
        {
            throw new NotImplementedException();
        }

        internal static List<Item> Convert(List<DBOrderItem> items)
        {
            throw new NotImplementedException();
        }
    }
}
