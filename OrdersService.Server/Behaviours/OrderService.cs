using OrdersService.Common.Models;
using OrdersService.DB;
using OrdersService.DB.DatabaseModels;
using OrdersService.Server.Contracts;
using OrdersService.Server.Requests;
using OrdersService.Server.Responses;
using OrdersService.Server.Utils.Converters;
using System;
using System.Collections.Generic;
using System.ServiceModel;

namespace OrdersService.Server.Behaviours
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class OrderService : IOrderService
    {
        private Database dbContext;

        public OrderService()
        {
            dbContext = new Database();
        }

        public OrdersListResponse GetAllOrders(BaseRequest request)
        {
            List<DBOrder> orders;
            try
            {
                orders = dbContext.GetAllOrders();
            }
            catch (Exception ex)
            {
                return new OrdersListResponse
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }

            return new OrdersListResponse
            {
                Orders = DBDataConverter.Convert(orders),
            };

        }
        public OrderDetailsResponse GetOrderDetails(GetOrderDetailsRequest request)
        {
            DBOrderDetails orderDetails;
            var response = new OrderDetailsResponse();

            try
            {
                orderDetails = dbContext.GetOrderDetails(request.RequestId);

                response.CustomerDetails = DBDataConverter.Convert(orderDetails.CustomerDetails);
                response.Items = DBDataConverter.Convert(orderDetails.Items);
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}
