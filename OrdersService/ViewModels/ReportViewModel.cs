using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using OrdersService.IoC;
using OrdersService.Utils;
using OrdersService.Utils.DataLoaders;
using System.Collections.Generic; 

namespace OrdersService.ViewModels
{
    public class ReportViewModel<T> : ViewModelBase
    {
        public RelayCommand BackCommand { get; set; }
        public List<T> Items { get; set; }
        public ReportViewModel(IDataLoader<List<T>> dataLoader)
        {
            Items = dataLoader.Load();
            BackCommand = new RelayCommand(() =>
            {
                IocKernel.Get<NavigationService>().NavigateToPrevious();
            });
        }
    }
}
