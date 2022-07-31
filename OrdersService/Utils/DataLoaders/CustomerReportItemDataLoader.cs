using AutoMapper;
using OrdersService.Models.Report;
using OrdersService.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OrdersService.Utils.DataLoaders
{
    public class CustomerReportItemDataLoader : DataLoader<List<CustomerReportItem>>
    {
        public override List<CustomerReportItem> Load()
        {
            var mapper = IoC.IocKernel.Get<Mapper>();
            var loader = new CustomersListLoader();
            var selectWindow = new SelectCustomerWindow(loader.Load());
            if (selectWindow.ShowDialog() == false)
                return null;

            var customerId = selectWindow.SelectedCustomer.Id;
            var result = orderService.GetCustomerOrders(new Core.OrderService.GetCustomerOrdersRequest
            {
                CustomerId = customerId,
            }); 
            if (result.IsSuccess)
                return mapper.Map<List<CustomerReportItem>>(result.CustomerOrders.ToList());
            else
                MessageBox.Show($"Couldn't get customer orders: {result.Message}", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            return null;
        }
    }
}
