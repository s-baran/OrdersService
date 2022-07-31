using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using OrdersService.IoC;
using OrdersService.Utils;
using OrdersService.Views;

namespace OrdersService.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        public RelayCommand ConnectCommand { get; set; }

        public LoginViewModel()
        {
            ConnectCommand = new RelayCommand(() =>
            {
                var ordersListPage = IocKernel.Get<OrdersListView>();
                ordersListPage.DataContext = new OrdersListViewModel();
                IocKernel.Get<NavigationService>().NavigateTo(ordersListPage);
            });
        }

    }
}
