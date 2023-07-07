using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgencyFramework.ViewModels
{
    internal class DealTypePageViewModel : ViewModelBase
    {
        private ObservableCollection<DealType> _dealTypes;
        public ObservableCollection<DealType> DealTypes { get { return _dealTypes; } set { _dealTypes = value; OnPropertyChanged(nameof(DealTypes)); } }
        public DealTypePageViewModel()
        {
            DealTypes = dbContext.DealType.Local;
        }
    }
}
