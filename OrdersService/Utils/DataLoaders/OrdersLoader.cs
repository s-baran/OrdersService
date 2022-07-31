using OrdersService.Core.OrderService;
using OrdersService.Core.Utils;
using OrdersService.Models;
using OrdersService.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Utils.DataLoaders
{
    public class OrdersLoader : DataLoader<List<Models.Order>>
    { 
        public override List<Models.Order> Load()
        {
            var response = orderService.GetAllOrders(new BaseRequest());
            var orders = new List<Models.Order>();
            if (response.IsSuccess)
            {
                foreach (var order in response.Orders)
                {
                    orders.Add(new Models.Order
                    {
                        CreationDate = order.CreationDate.ToLocalTime(),
                        Id = order.Id,
                        Name = order.Name,
                        OrderStatus = (Models.OrderStatus)Enum.Parse(typeof(Models.OrderStatus), order.OrderStatus.ToString())
                    });
                }
                return orders;
            }
            else return new List<Models.Order>();
        } 
    }
}
