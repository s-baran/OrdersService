using OrdersService.Core.OrderService;
using OrdersService.Core.Utils;
using OrdersService.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Utils.DataLoaders
{
    public abstract class DataLoader<T>
    {
        public IOrderService orderService { get; }

        public DataLoader()
        {
            orderService = new ServiceProvider<IOrderService>(Settings.Default.ServiceUri).GetOrderService();
        }

        public abstract T Load();
    }
}
