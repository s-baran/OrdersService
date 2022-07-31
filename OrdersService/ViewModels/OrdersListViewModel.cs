using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using OrdersService.IoC;
using OrdersService.Models;
using OrdersService.Utils;
using OrdersService.Utils.DataLoaders;
using OrdersService.Views;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OrdersService.ViewModels
{
    public partial class OrdersListViewModel : ViewModelBase
    {
        private NavigationService navigationService;


        private List<Order> ordersList;

        public List<Order> OrdersList
        {
            get => ordersList;
            set { ordersList = value; RaisePropertyChanged(nameof(OrdersList)); }
        }

         
        public RelayCommand AddOrderCommand { get; set; }
        public RelayCommand<int> ViewDetailsCommand { get; set; }
        public RelayCommand LoadedCommand { get; set; }
        public OrdersListViewModel()
        {
            navigationService = IocKernel.Get<NavigationService>();
            InitializeCommands();
        }

        private void InitializeCommands()
        {
            AddOrderCommand = new RelayCommand(() =>
            {
                var form = new NewOrderDetailsWindow();
                var vm = new NewOrderDetailsViewModel(new ItemsLoader().Load())
                {
                    WindowClose = new Action(form.Close)
                };
                form.DataContext = vm;
                form.ShowDialog();
                LoadedCommand.Execute(null);
            });
            ViewDetailsCommand = new RelayCommand<int>((id) =>
            {
                var order = OrdersList.Where(x => x.Id == id).FirstOrDefault();
                ShowOrderDetails(order);
            });
            LoadedCommand = new RelayCommand(() =>
            {
                var loader = new OrdersLoader();
                OrdersList = loader.Load();
            });
        }

       
        private void ShowOrderDetails(Order order)
        {
            var orderDetailsView = IocKernel.Get<OrderDetailsView>();
            var viewModel = new OrderDetailsViewModel()
            {
                Order = order
            };
            orderDetailsView.DataContext = viewModel;
            navigationService.NavigateTo(orderDetailsView);
        }
    }
}
