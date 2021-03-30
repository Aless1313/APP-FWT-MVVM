using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using App_FWT_MVVM.Models;
using Xamarin.Forms;
using Newtonsoft.Json;
using System.ComponentModel;
using System.Linq;
using App_FWT_MVVM.Views;
using Android.Content.Res;

namespace App_FWT_MVVM.ViewModels 
{
    
    public class LoginViewModel : INotifyPropertyChanged
    {
       
        public event PropertyChangedEventHandler PropertyChanged;

        private string email;
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Email"));
                
            }
        }

        private string password;
        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                PropertyChanged(this, new PropertyChangedEventArgs("Password"));
            }
        }

        public Command LoginCommand
        {
            get
            {
                return new Command(Login);
            }
        }

        public Command RegisterCommand
        {
            get
            {
                return new Command(Register);
            }
        }

        public Command ForgotCommand
        {
            get
            {
                return new Command(Forgot);
            }
        }

        private Account data;

        public Account Data { get => data;
            set {
                data = value; 
            }
            
        }

        public async void Forgot()
        {
            await App.Current.MainPage.DisplayAlert("Evento", "Recuperar contraseña", "Ok");
        }

        public async void Register()
        {
            await App.Current.MainPage.Navigation.PushAsync(new Register());
        }

        public async void Login()
        {
            if(string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Campos Vacios", "Ingrese su usuario y contraseña", "Ok");
            }
            else
            {
                await GetData("https://dev-fwt.ga/php/login.php?mail=" + Email.ToString() + "&password=" + Password.ToString() );
            }
        }

        
        

        private async Task GetData(string url)
        {
            var client = new HttpClient();
            var response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var jsonResult = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Account>>(jsonResult);
           
             
            if(result.Count() > 0)
            {
                

                Device.BeginInvokeOnMainThread(() => App.Current.MainPage = new NavigationPage(new Dashboard()));

                //await App.Current.MainPage.Navigation.PushAsync(new Dashboard());
                Data = result[0];
            }
            else
            {
                await App.Current.MainPage.DisplayAlert("Login Fail", "Please enter correct Email and Password", "OK");
            }
        }
    }
}
