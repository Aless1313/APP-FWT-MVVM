using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using App_FWT_MVVM.ViewModels;


namespace App_FWT_MVVM.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        RegisterViewModel registerViewModel;
        public Register()
        {
            registerViewModel = new RegisterViewModel();
            InitializeComponent();
            BindingContext = registerViewModel;

        }
    }
}