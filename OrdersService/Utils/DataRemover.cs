using OrdersService.Core.OrderService;
using OrdersService.Core.Utils;
using OrdersService.Properties;
using System.Windows;

namespace OrdersService.Utils
{
    public class DataRemover
    {
        private readonly IOrderService orderService;

        public DataRemover()
        {
            orderService = new ServiceProvider<IOrderService>(Settings.Default.ServiceUri).GetOrderService();
        }

        public bool RemoveOrder(Models.Order order)
        {
            var response = orderService.RemoveOrder(new RemoveOrderRequest(order.Id));
            if (!response.IsSuccess)
                MessageBox.Show($"{response.Message}", "Error",MessageBoxButton.OK, MessageBoxImage.Error);
            return response.IsSuccess;
        }
       
    }
}
