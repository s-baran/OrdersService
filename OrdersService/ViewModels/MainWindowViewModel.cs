using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using OrdersService.Core.OrderService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        static string uri = "net.tcp://localhost:6565/OrderService";
        private IOrderService orderService;
        public MainWindowViewModel()
        {
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            LoginCommand = new RelayCommand(() =>
            {
                if (orderService == null)
                {
                    NetTcpBinding binding = new NetTcpBinding(SecurityMode.None);
                    var channel = new ChannelFactory<IOrderService>(binding);
                    var endpoint = new EndpointAddress(uri);
                    orderService = channel.CreateChannel(endpoint);
                }
            });
            GetOrdersCommand = new RelayCommand(() =>
            {
                OrdersListResponse list = orderService.GetAllOrders(new BaseRequest());
            });
            CloseCommand = new RelayCommand(() =>
            {
                RequestClose();
            });
        }

        public Action RequestClose { get; internal set; }

        public RelayCommand CloseCommand { get; set; }
        public RelayCommand GetOrdersCommand { get; set; }
        public RelayCommand LoginCommand { get; set; }
    }
}
