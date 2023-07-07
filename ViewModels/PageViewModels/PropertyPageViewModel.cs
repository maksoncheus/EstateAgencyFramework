using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgencyFramework.ViewModels
{
    internal class PropertyPageViewModel : ViewModelBase
    {
        private ObservableCollection<Property> _properties;
        public ObservableCollection<Property> Properties { get { return _properties; } set { _properties = value; OnPropertyChanged(nameof(Properties)); } }
        public PropertyPageViewModel()
        {
            Properties = dbContext.Property.Local;
        }
    }
}
