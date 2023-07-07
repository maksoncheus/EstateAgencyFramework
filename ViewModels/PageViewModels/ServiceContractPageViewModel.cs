using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgencyFramework.ViewModels
{
    internal class ServiceContractPageViewModel : ViewModelBase
    {
        private ObservableCollection<ServiceContract> _serviceContract;
        public ObservableCollection<ServiceContract> ServiceContracts { get { return _serviceContract; } set { _serviceContract = value; OnPropertyChanged(nameof(ServiceContracts)); } }
        public ServiceContractPageViewModel()
        {
            ServiceContracts = dbContext.ServiceContract.Local;
        }
    }
}
