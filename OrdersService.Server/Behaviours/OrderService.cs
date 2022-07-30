using OrdersService.Common.Models;
using OrdersService.DB;
using OrdersService.Server.Contracts;
using OrdersService.Server.Requests;
using OrdersService.Server.Responses;
using System.Collections.Generic;
using System.ServiceModel;

namespace OrdersService.Server.Behaviours
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class OrderService : IOrderService
    {

        public OrdersListResponse GetAllOrders(BaseRequest request)
        {
            var db = new Database();
            var orders = db.GetAllOrders();

            var response = new OrdersListResponse
            {
                Orders = orders,
                IsSuccess = true,
            };

            return response;
        }
    }
}
