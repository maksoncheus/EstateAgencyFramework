using EstateAgencyFramework.NavigationHelper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace EstateAgencyFramework
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
        }

        void App_Navigated(object sender, NavigationEventArgs e)
        {
            Page page = (Page)e.Content;
            if (page != null)
                Navigation.NavigationService = page.NavigationService;
        }
    }
}
