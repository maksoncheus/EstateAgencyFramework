using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgencyFramework.ViewModels
{
    internal class RolePageViewModel : ViewModelBase
    {
        private ObservableCollection<Role> _roles;
        public ObservableCollection<Role> RolesList { get { return _roles; } set { _roles = value; OnPropertyChanged(nameof(RolesList)); } }
        public RolePageViewModel()
        {
            RolesList = dbContext.Role.Local;
        }
    }
}
