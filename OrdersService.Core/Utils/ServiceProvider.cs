using OrdersService.Core.OrderService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Core.Utils
{
    public class ServiceProvider<T>
    {
        private string uri;
        public ServiceProvider(string uri)
        {
            this.uri = uri;
        }
        public T GetOrderService()
        {
            NetTcpBinding binding = new NetTcpBinding(SecurityMode.None);
            var channel = new ChannelFactory<IOrderService>(binding);
            var endpoint = new EndpointAddress(uri);
            return (T)channel.CreateChannel(endpoint);
        }
    }
}
