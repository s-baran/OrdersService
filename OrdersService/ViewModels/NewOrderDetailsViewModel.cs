using AutoMapper;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using OrdersService.IoC;
using OrdersService.Models;
using OrdersService.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace OrdersService.ViewModels
{
    public partial class NewOrderDetailsViewModel : ViewModelBase
    {

        public RelayCommand SaveCommand { get; set; }
        public RelayCommand OnBackCommand { get; set; } 

        public Action WindowClose { get; set; }
        public OrderDetails Order { get; set; }

        private List<SelectableItem> itemsList;

        public List<SelectableItem> ItemsList
        {
            get => itemsList;
            set { itemsList = value; RaisePropertyChanged(nameof(ItemsList)); }
        }

        public NewOrderDetailsViewModel(List<Item> items)
        {
            Order = new OrderDetails()
            {
                Customer = new CustomerDetails()
            };

            var list = new List<SelectableItem>();
            foreach (var item in items)
            {
                list.Add(
                    new SelectableItem
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Price = item.Price
                    });
            }
            ItemsList = list;


            InitializeCommands();
        }

        private void InitializeCommands()
        {
          
            OnBackCommand = new RelayCommand(() =>
            {
                WindowClose?.Invoke();
            });
            SaveCommand = new RelayCommand(async() =>
            {
                if (ValidateOutput())
                {
                    PrepareItems();
                    await CreateOrderInDatabase();
                }
            });
        }

        private void PrepareItems()
        {
            var mapper = IocKernel.Get<Mapper>();
            Order.Items = mapper.Map<List<Item>>(ItemsList.Where(i => i.IsSelected).ToList());
      
        }

        private async Task CreateOrderInDatabase()
        {
            var insert = new DataInserter();
            var response = await insert.InsertNewOrder(Order);
            if (response.IsSuccess)
                WindowClose?.Invoke();
            else
                MessageBox.Show($"Error while creating order: {response.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private bool ValidateOutput()
        {
            if(string.IsNullOrWhiteSpace(Order.Name)|| Order.Customer.GetType().GetProperties().Where(p=>p.PropertyType == typeof(string)).Any(p=> string.IsNullOrWhiteSpace((string)p.GetValue(Order.Customer))))
            {
                return false;
            }
            else return true;
        }
    }
}
