using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgencyFramework.ViewModels
{
    internal class CommonContractPageViewModel :ViewModelBase
    {
        private ObservableCollection<CommonContract> _commonContracts;
        public ObservableCollection<CommonContract> CommonContracts { get { return _commonContracts; } set { _commonContracts = value; OnPropertyChanged(nameof(CommonContracts)); } }
        public CommonContractPageViewModel()
        {
            CommonContracts = dbContext.CommonContract.Local;
        }
    }
}
