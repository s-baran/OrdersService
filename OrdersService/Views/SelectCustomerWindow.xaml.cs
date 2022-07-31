using OrdersService.Models;
using System.Collections.Generic;
using System.Windows;

namespace OrdersService.Views
{
    /// <summary>
    /// Interaction logic for SelectCustomerWindow.xaml
    /// </summary>
    public partial class SelectCustomerWindow : Window
    {
        public List<CustomerDetails> Customers { get; set; }
        public CustomerDetails SelectedCustomer { get; set; }
        public SelectCustomerWindow(List<CustomerDetails> customers)
        {
            Customers = customers;
            InitializeComponent();
        }

        private void DataGrid_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            DialogResult = true;
            Close();
        }
    }
}
