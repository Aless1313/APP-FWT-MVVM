using App_FWT_MVVM.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_FWT_MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        LoginViewModel loginViewModel;
        public Login()
        {
            loginViewModel = new LoginViewModel();
            InitializeComponent();
           
            BindingContext = loginViewModel;
        }
    }
}