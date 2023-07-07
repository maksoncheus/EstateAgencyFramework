using System;
using EstateAgencyFramework.Pages;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace EstateAgencyFramework.NavigationHelper
{
    internal static class Navigation
    {
        private static NavigationService navigator;

        public static NavigationService NavigationService
        {
            set
            {
                navigator = value;
            }
            get
            {
                return navigator;
            }
        }
        public static Page GetUserRolePage(int roleID)
        {
            Page returnPage = null;
            switch(roleID)
            {
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    returnPage = new AdminPage();
                    break;
                case 4:
                    returnPage = new AdminPage();
                    break;
            }
            return returnPage;
        }
        public static Uri GetPageUri(string pageName) => new Uri("InternalPages/" + pageName, UriKind.Relative);
    }
}
