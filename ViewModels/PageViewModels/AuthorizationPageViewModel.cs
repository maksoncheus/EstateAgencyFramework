using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgencyFramework.ViewModels
{
    internal class AuthorizationPageViewModel : ViewModelBase
    {
        private ObservableCollection<Authorization> _authorization;
        public ObservableCollection<Authorization> AurhorizationList { get { return _authorization; } set { _authorization = value; OnPropertyChanged(nameof(AurhorizationList)); } }
        public AuthorizationPageViewModel()
        {
            AurhorizationList = dbContext.Authorization.Local;
        }
    }
}
