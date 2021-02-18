using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_FWT_MVVM.Views;

namespace App_FWT_MVVM
{
    public partial class App : Application
    {
        public App()
        {
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mzk1MTAyQDMxMzgyZTM0MmUzMGwzTGU2bDdwVEd3UmpZY3lYVjYrVGl2R2FvNU56R0tTaXBsVlNsUjQwN2M9");
            InitializeComponent();

            //MainPage = new NavigationPage(new Login());
            MainPage = new NavigationPage(new MasterShell());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
