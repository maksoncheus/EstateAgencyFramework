using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgencyFramework.ViewModels
{
    internal class RealtyCharacteristicPageViewModel : ViewModelBase
    {
        private ObservableCollection<RealtyCharacteristic> _realtyCharacteristics;
        public ObservableCollection<RealtyCharacteristic> RealtyCharacteristics { get { return _realtyCharacteristics; } set { _realtyCharacteristics = value; OnPropertyChanged(nameof(RealtyCharacteristics)); } }
        public RealtyCharacteristicPageViewModel()
        {
            RealtyCharacteristics = dbContext.RealtyCharacteristic.Local;
        }
    }
}
