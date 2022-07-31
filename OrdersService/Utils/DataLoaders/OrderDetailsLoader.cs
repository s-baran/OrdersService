using OrdersService.Models;
using System.Collections.Generic;

namespace OrdersService.Utils.DataLoaders
{
    public class OrderDetailsLoader : DataLoader<OrderDetails>
    {
        private Order order;
        public OrderDetailsLoader(Order order)
        {
            this.order = order;
        }

        public override OrderDetails Load()
        {
            var orderDetails = new OrderDetails(order);
            var response = orderService.GetOrderDetails(new Core.OrderService.GetOrderDetailsRequest
            {
                OrderId = order.Id
            });
            if (!response.IsSuccess)
            {
                return null;
            }
            else
            {
                orderDetails.Customer = new CustomerDetails
                {
                    FirstName = response.CustomerDetails.FirstName,
                    LastName = response.CustomerDetails.LastName,
                    Address = response.CustomerDetails.Address,
                    PhoneNumber = response.CustomerDetails.PhoneNumber
                };
                var itemsList = new List<Item>();
                foreach (var item in response.Items)
                {
                    itemsList.Add(new Item
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Price = item.Price,
                        Quantity = item.Quantity
                    });
                }
                orderDetails.Items = itemsList;
            }
            return orderDetails;
        }
    }
}
