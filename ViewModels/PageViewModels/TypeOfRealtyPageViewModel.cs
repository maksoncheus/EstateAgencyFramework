using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgencyFramework.ViewModels
{
    internal class TypeOfRealtyPageViewModel : ViewModelBase
    {
        private ObservableCollection<TypeOfRealty> _typesOfRealty;
        public ObservableCollection<TypeOfRealty> TypesOfRealty { get { return _typesOfRealty; } set { _typesOfRealty = value; OnPropertyChanged(nameof(TypesOfRealty)); } }
        public TypeOfRealtyPageViewModel()
        {
            TypesOfRealty = dbContext.TypeOfRealty.Local;
        }
    }
}
