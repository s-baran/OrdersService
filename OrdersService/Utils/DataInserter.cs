using AutoMapper;
using OrdersService.Core.OrderService;
using OrdersService.Core.Utils;
using OrdersService.Properties;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrdersService.Utils
{
    public class DataInserter
    {
        private readonly IOrderService orderService;

        public DataInserter()
        {
            orderService = new ServiceProvider<IOrderService>(Settings.Default.ServiceUri).GetOrderService();
        }

        public async Task<BaseResponse> InsertNewOrder(Models.OrderDetails orderDetails)
        {
            var mapper = IoC.IocKernel.Get<Mapper>();
            var response = await orderService.AddNewOrderAsync(new AddOrderRequest
            {
                CreateOrderModel = new CreateOrderModelDto
                {
                    Customer = mapper.Map<CustomerDto>(orderDetails.Customer),
                    Items = mapper.Map<List<OrderItemDto>>(orderDetails.Items).ToArray(),
                    OrderName = orderDetails.Name
                }
            });
            return response;
        }
    }

}
