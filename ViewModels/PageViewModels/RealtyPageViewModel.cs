using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgencyFramework.ViewModels
{
    internal class RealtyPageViewModel : ViewModelBase
    {
        private ObservableCollection<Realty> _realties;
        public ObservableCollection<Realty> Realties { get { return _realties; } set { _realties = value; OnPropertyChanged(nameof(Realties)); } }
        public RealtyPageViewModel()
        {
            Realties = dbContext.Realty.Local;
        }
    }
}
