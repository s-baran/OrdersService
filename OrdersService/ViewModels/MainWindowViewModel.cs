using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using OrdersService.IoC;
using OrdersService.Utils;
using OrdersService.Views;
using System;

namespace OrdersService.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
       
        private NavigationService navigationService;

        public MainWindowViewModel()
        {
            InitializeCommands();
            navigationService = IocKernel.Get<NavigationService>();
        }
        public RelayCommand OnLoadedCommand { get; set; }

        private void InitializeCommands()
        {
            OnLoadedCommand = new RelayCommand(() =>
            {
                navigationService.NavigateTo(new LoginView { DataContext = new LoginViewModel()}); 
            });
        
        }

        public Action RequestClose { get; internal set; }

    }
}
