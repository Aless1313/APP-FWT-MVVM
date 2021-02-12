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
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
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
