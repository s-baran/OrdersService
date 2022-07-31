using System.Windows;

using OrdersService.IoC;
using OrdersService.Utils;

namespace OrdersService.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeNavigationService();
        }

        private void InitializeNavigationService()
        {
            var navigationService = IocKernel.Get<NavigationService>();
            navigationService.Initialize(content);
        }
    }
}
