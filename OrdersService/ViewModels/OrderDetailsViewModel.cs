using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using OrdersService.IoC;
using OrdersService.Models;
using OrdersService.Utils;
using OrdersService.Utils.DataLoaders;
using System.Windows;

namespace OrdersService.ViewModels
{
    public partial class OrderDetailsViewModel : ViewModelBase
    {
        public OrderDetailsViewModel()
        {
            InitializeCommands();
        }

        public Order Order { get; internal set; }

        private OrderDetails orderDetails;

        public OrderDetails OrderDetails
        {
            get => orderDetails;
            set { orderDetails = value; RaisePropertyChanged(nameof(OrderDetails)); }
        }
        
        public RelayCommand OnLoadedCommand { get; set; }
        public RelayCommand BackCommand { get; set; }
        public RelayCommand DeleteCommand { get; set; }
        private void InitializeCommands()
        {
            OnLoadedCommand = new RelayCommand(() =>
            {
                var loader = new OrderDetailsLoader(Order);
                OrderDetails = loader.Load();
                if (OrderDetails == null)
                {
                    MessageBox.Show("Something went wrong.", "Warning!", MessageBoxButton.OK, MessageBoxImage.Error);
                    NavigateBack();
                }
            });
            BackCommand = new RelayCommand(() => NavigateBack());
            DeleteCommand = new RelayCommand(() =>
            {
                var remover = new DataRemover();
                if (remover.RemoveOrder(orderDetails))
                {
                    BackCommand.Execute(null);
                }
            });
        }
        private void NavigateBack()
        {
            IocKernel.Get<NavigationService>().NavigateToPrevious();
        }

    }
}
