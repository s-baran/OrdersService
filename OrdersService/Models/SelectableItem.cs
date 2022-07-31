using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersService.Models
{
    public class SelectableItem : ObservableObject
    {
        public RelayCommand IncrementCommand => new RelayCommand(() =>
        {
            Quantity++;
            if (Quantity > 0)
                IsSelected = true;
            RaisePropertyChanged(nameof(IsSelected));
            RaisePropertyChanged(nameof(Quantity));
        });
        public RelayCommand DecrementCommand => new RelayCommand(() =>
        {
            if (Quantity == 0)
                return;
            Quantity--;
            if (Quantity == 0)
                IsSelected = false;
            RaisePropertyChanged(nameof(IsSelected));
            RaisePropertyChanged(nameof(Quantity));
        });

        private bool isSelected;

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool IsSelected
        {
            get
            {
                return isSelected;
            }
            set
            {
                isSelected = value;
                if (!isSelected && Quantity > 0)
                    Quantity = 0;
                if (isSelected && Quantity == 0)
                    Quantity = 1;
                RaisePropertyChanged(nameof(Quantity));
            }
        }
        public uint Quantity { get; set; } = 0;
    }
}
