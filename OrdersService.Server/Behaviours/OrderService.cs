using AutoMapper;
using OrdersService.Common.Models;
using OrdersService.DB;
using OrdersService.DB.DatabaseModels;
using OrdersService.Server.Contracts;
using OrdersService.Server.Requests;
using OrdersService.Server.Responses;
using OrdersService.Server.Utils;
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
        private Mapper mapper = MapperResolver.Mapper;
        public OrderService()
        {
            dbContext = new Database();
        }

        public BaseResponse AddNewOrder(AddOrderRequest request)
        {
            try
            {
                var initialStatus = OrderStatusDto.Pending;
                var statusId = dbContext.GetStatusID(initialStatus.ToString());
                if (statusId < 0)
                    dbContext.CreateStatus(initialStatus.ToString());

                var customerId = dbContext.CreateCustomer(mapper.Map<DBCustomer>(request.CreateOrderModel.Customer));

                var orderid = dbContext.CreateNewOrder(new DBNewOrder
                {
                    CustomerId = customerId,
                    Name = request.CreateOrderModel.OrderName,
                    OrderStatusId = statusId,
                });
                var itemsInputList = new List<DBOrderItem>();
                foreach (var item in request.CreateOrderModel.Items)
                {
                    itemsInputList.Add(MapperResolver.Mapper.Map<DBOrderItem>(item));
                }
                itemsInputList.ForEach(item => item.OrderId = orderid);
                dbContext.CreateOrderItems(itemsInputList);
            }
            catch (Exception ex)
            {
                new BaseResponse { IsSuccess = false, Message = ex.Message };
            }
            return new BaseResponse { IsSuccess = true };
        }

        public ItemsListResponse GetAllItems(BaseRequest request)
        {
            Console.WriteLine("GetAllItems requested");
            List<DBItem> items;
            try
            {
                items = dbContext.GetAllItems();
            }
            catch (Exception ex)
            {
                return new ItemsListResponse
                {
                    IsSuccess = false,
                    Message = ex.Message
                };
            }

            return new ItemsListResponse
            {
                Items = DBDataConverter.Convert(items),
            };
        }

        public OrdersListResponse GetAllOrders(BaseRequest request)
        {
            Console.WriteLine("GetAllOrders requested");
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
            Console.WriteLine($"GetOrderDetails requested for order id: {request.OrderId}");
            DBOrderDetails orderDetails;
            var response = new OrderDetailsResponse();

            try
            {
                orderDetails = dbContext.GetOrderDetails(request.OrderId);

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

        public BaseResponse RemoveOrder(RemoveOrderRequest request)
        {
            Console.WriteLine($"RemoveOrder requested for order id: {request.OrderId}");
            try
            {
                dbContext.RemoveOrder(request.OrderId);
            }
            catch (Exception ex)
            {
                new BaseResponse { IsSuccess = false, Message = ex.Message };
            }
            return new BaseResponse { IsSuccess = true };
        }
    }
}
