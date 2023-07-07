using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgencyFramework.ViewModels
{
    internal class UserPageViewModel : ViewModelBase
    {

        private ObservableCollection<User> _users;
        public ObservableCollection<User> UserList { get { return _users; } set { _users = value; OnPropertyChanged(nameof(UserList)); } }
        public UserPageViewModel()
        {
            UserList = dbContext.User.Local;
        }
    }
}
