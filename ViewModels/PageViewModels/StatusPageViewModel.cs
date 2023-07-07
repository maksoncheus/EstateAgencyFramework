using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgencyFramework.ViewModels
{
    internal class StatusPageViewModel : ViewModelBase
    {
        private ObservableCollection<Status> _statuses;
        public ObservableCollection<Status> Statuses { get { return _statuses; } set { _statuses = value; OnPropertyChanged(nameof(Statuses)); } }
        public StatusPageViewModel()
        {
            Statuses = dbContext.Status.Local;
        }
    }
}
