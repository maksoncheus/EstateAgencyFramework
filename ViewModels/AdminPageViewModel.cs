using EstateAgencyFramework.Pages;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace EstateAgencyFramework.ViewModels
{
    internal class AdminPageViewModel : ViewModelBase
    {
        private bool _isPageSelected;
        public bool IsPageSelected { get { return _isPageSelected; } set { _isPageSelected = value; OnPropertyChanged(nameof(IsPageSelected)); } }
        private Uri selectedPageUri;
        public Uri SelectedPage
        {
            get { return selectedPageUri; }
            set { selectedPageUri = value; IsPageSelected = true; OnPropertyChanged(nameof(SelectedPage)); }
        }
        private string _selectedPageTitle;
        public string SelectedPageTitle { get { return _selectedPageTitle; } set { _selectedPageTitle = value; SelectedPage = NavigationHelper.Navigation.GetPageUri(value.ToLower().Replace("system.windows.controls.listboxitem: ", "") + ".xaml"); OnPropertyChanged(nameof(SelectedPageTitle)); } }
        public AdminPageViewModel()
        {
            IsPageSelected = false;
            //SelectedPage = NavigationHelper.Navigation.GetPageUri("RolesPage.xaml");
        }
    }
}
